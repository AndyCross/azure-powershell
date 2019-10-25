// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Sql.Common;
using Microsoft.Azure.Management.Internal.Resources;
using Microsoft.Azure.Management.Sql;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.Sql.InstanceFailoverGroup.Services
{
    /// <summary>
    /// This class is responsible for all the REST communication with the audit REST endpoints
    /// </summary>
    public class AzureSqlInstanceFailoverGroupCommunicator
    {
        /// <summary>
        /// The Sql client to be used by this end points communicator
        /// </summary>
        private static SqlManagementClient SqlClient { get; set; }

        /// <summary>
        /// Gets or set the Azure subscription
        /// </summary>
        private static IAzureSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or sets the Azure profile
        /// </summary>
        public IAzureContext Context { get; set; }

        /// <summary>
        /// Creates a communicator for Instance Failover Group
        /// </summary>
        /// <param name="profile"></param>
        /// <param name="subscription"></param>
        public AzureSqlInstanceFailoverGroupCommunicator(IAzureContext context)
        {
            Context = context;
            if (context.Subscription != Subscription)
            {
                Subscription = context.Subscription;
                SqlClient = null;
            }
        }

        /// <summary>
        /// Gets the Instance Failover Group
        /// </summary>
        public Management.Sql.Models.InstanceFailoverGroup Get(string resourceGroupName, string location, string instanceFailoverGroupName)
        {
            return GetCurrentSqlClient().InstanceFailoverGroups.Get(resourceGroupName, location, instanceFailoverGroupName);
        }

        /// <summary>
        /// Lists Instance Failover Groups
        /// </summary>
        public IList<Management.Sql.Models.InstanceFailoverGroup> List(string resourceGroupName, string location)
        {
            return GetCurrentSqlClient().InstanceFailoverGroups.ListByLocation(resourceGroupName, location).ToList();
        }

        /// <summary>
        /// Creates or updates an Instance Failover Group
        /// </summary>
        public Management.Sql.Models.InstanceFailoverGroup CreateOrUpdate(string resourceGroupName, string location, string instanceFailoverGroupName, Management.Sql.Models.InstanceFailoverGroup parameters)
        {
            var resp = GetCurrentSqlClient().InstanceFailoverGroups.CreateOrUpdate(resourceGroupName, location, instanceFailoverGroupName, parameters);
            return resp;
        }

        /// <summary>
        /// Deletes an Instance Failover Group
        /// </summary>
        public void Remove(string resourceGroupName, string location, string instanceFailoverGroupName)
        {
            GetCurrentSqlClient().InstanceFailoverGroups.Delete(resourceGroupName, location, instanceFailoverGroupName);
        }

        /// <summary>
        /// Fail over an Instance Failover Group without data loss
        /// </summary>
        public void Failover(string resourceGroupName, string location, string instanceFailoverGroupName)
        {
            GetCurrentSqlClient().InstanceFailoverGroups.Failover(resourceGroupName, location, instanceFailoverGroupName);
        }

        /// <summary>
        /// Fail over an Instance Failover Group with data loss
        /// </summary>
        public void ForceFailoverAllowDataLoss(string resourceGroupName, string location, string instanceFailoverGroupName)
        {
            GetCurrentSqlClient().InstanceFailoverGroups.ForceFailoverAllowDataLoss(resourceGroupName, location, instanceFailoverGroupName);
        }

        /// <summary>
        /// Retrieve the SQL Management client for the currently selected subscription, adding the session and request
        /// id tracing headers for the current cmdlet invocation.
        /// </summary>
        /// <returns>The SQL Management client for the currently selected subscription.</returns>
        private SqlManagementClient GetCurrentSqlClient()
        {
            // Get the SQL management client for the current subscription
            if (SqlClient == null)
            {
                SqlClient = AzureSession.Instance.ClientFactory.CreateArmClient<SqlManagementClient>(Context, AzureEnvironment.Endpoint.ResourceManager);
            }
            return SqlClient;
        }

    }
}