﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Authentication.Utilities
{
    public static class HttpRetryAlgorithm
    {
        const int DefaultMaxTries = 5, DefaultMultiplier = 2;
        static readonly TimeSpan DefaultInterval = TimeSpan.FromSeconds(1);
        public static IHttpRetryAlgorithm Default { get { return new ExponentialRetryAlgorithm(DefaultInterval, DefaultMultiplier, DefaultMaxTries); } }

        public static IHttpRetryAlgorithm GetLinearRetryAlgorithm( TimeSpan interval, int maxTries)
        {
            return new LinearRetryAlgorithm(interval, maxTries);
        }

        public static IHttpRetryAlgorithm GetExponentialRetryAlgorithm( TimeSpan initial, int multiplier, int maxTries)
        {
            return new ExponentialRetryAlgorithm(initial, multiplier, maxTries);
        }

        class LinearRetryAlgorithm : IHttpRetryAlgorithm
        {
            TimeSpan _interval;
            int _maxTries;
            int _tries;


            public LinearRetryAlgorithm(TimeSpan interval, int maxTries)
            {
                _interval = interval;
                _maxTries = maxTries;
            }

            public TimeSpan GetRetryInterval()
            {
                return _interval;
            }

            public bool ShouldRetry(HttpResponseMessage message)
            {
                
                switch(message?.StatusCode)
                {
                    case HttpStatusCode.Conflict:
                    case HttpStatusCode.GatewayTimeout:
                    case HttpStatusCode.InternalServerError:
                    case HttpStatusCode.RequestTimeout:
                    case HttpStatusCode.ServiceUnavailable:
                    case (HttpStatusCode)429:
                        return _tries++ < _maxTries;
                    default:
                        return false;
                }
            }

            public Task WaitForRetry()
            {
                TimeSpan waitTimeSpan = _tries > 0 ? _interval : TimeSpan.MinValue;
                return Task.Delay(waitTimeSpan);
            }
        }

        class ExponentialRetryAlgorithm : IHttpRetryAlgorithm
        {
            TimeSpan _currentInterval;
            int _multiplier;
            int _maxTries;
            int _tries = 0;

            public ExponentialRetryAlgorithm(TimeSpan initialInterval, int multiplier, int maxTries)
            {
                _currentInterval = initialInterval;
                _multiplier = multiplier;
                _maxTries = maxTries;
            }
            public TimeSpan GetRetryInterval()
            {
                var result = _currentInterval;
                _currentInterval = TimeSpan.FromTicks(_currentInterval.Ticks * _multiplier);
                return _currentInterval;

            }

            public bool ShouldRetry(HttpResponseMessage message)
            {
                ++_tries;
                switch (message?.StatusCode)
                {
                    case HttpStatusCode.Conflict:
                    case HttpStatusCode.GatewayTimeout:
                    case HttpStatusCode.InternalServerError:
                    case HttpStatusCode.RequestTimeout:
                    case HttpStatusCode.ServiceUnavailable:
                    case (HttpStatusCode)429:
                        return _tries <= _maxTries;
                    default:
                        return false;
                }
            }

            public Task WaitForRetry()
            {
                TimeSpan waitTimeSpan = _tries > 0 ? GetRetryInterval() : TimeSpan.MinValue;
                return Task.Delay(waitTimeSpan);
            }
        }
    }
}
