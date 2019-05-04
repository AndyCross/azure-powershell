---
external help file: Az.ServiceBus-help.xml
Module Name: Az.ServiceBus
online version: https://docs.microsoft.com/en-us/powershell/module/az.servicebus/get-azservicebusdisasterrecoveryconfig
schema: 2.0.0
---

# Get-AzServiceBusDisasterRecoveryConfig

## SYNOPSIS
Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace

## SYNTAX

### ListSubscriptionIdViaHost (Default)
```
Get-AzServiceBusDisasterRecoveryConfig -NamespaceName <String> -ResourceGroupName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetSubscriptionIdViaHost
```
Get-AzServiceBusDisasterRecoveryConfig -AliasName <String> -NamespaceName <String> -ResourceGroupName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzServiceBusDisasterRecoveryConfig -AliasName <String> -NamespaceName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List
```
Get-AzServiceBusDisasterRecoveryConfig -NamespaceName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -AliasName
The Disaster Recovery configuration name

```yaml
Type: System.String
Parameter Sets: GetSubscriptionIdViaHost, Get
Aliases: Alias

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NamespaceName
The namespace name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Namespace

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the Resource group within the Azure subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription credentials that uniquely identify a Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20170401.IArmDisasterRecovery
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.servicebus/get-azservicebusdisasterrecoveryconfig](https://docs.microsoft.com/en-us/powershell/module/az.servicebus/get-azservicebusdisasterrecoveryconfig)
