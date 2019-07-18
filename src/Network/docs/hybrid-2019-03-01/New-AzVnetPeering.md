---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-azvnetpeering
schema: 2.0.0
---

# New-AzVnetPeering

## SYNOPSIS
Creates or updates a peering in the specified virtual network.

## SYNTAX

### Create1 (Default)
```
New-AzVnetPeering -ResourceGroupName <String> -SubscriptionId <String> -VnetName <String> [-Name <String>]
 [-VnetPeeringParameter <IVirtualNetworkPeering>] [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-AzVnetPeering -InputObject <INetworkIdentity> [-Name <String>] [-AllowForwardedTraffic]
 [-AllowGatewayTransit] [-AllowVnetAccess] [-Etag <String>] [-Id <String>]
 [-PeeringState <VirtualNetworkPeeringState>] [-ProvisioningState <String>]
 [-RemoteAddressSpaceAddressPrefix <String[]>] [-RemoteVnetId <String>] [-UseRemoteGateway]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded1
```
New-AzVnetPeering -ResourceGroupName <String> -SubscriptionId <String> -VnetName <String>
 -VnetPeeringName <String> [-Name <String>] [-AllowForwardedTraffic] [-AllowGatewayTransit] [-AllowVnetAccess]
 [-Etag <String>] [-Id <String>] [-PeeringState <VirtualNetworkPeeringState>] [-ProvisioningState <String>]
 [-RemoteAddressSpaceAddressPrefix <String[]>] [-RemoteVnetId <String>] [-UseRemoteGateway]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-AzVnetPeering -InputObject <INetworkIdentity> [-VnetPeeringParameter <IVirtualNetworkPeering>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a peering in the specified virtual network.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AllowForwardedTraffic
Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowGatewayTransit
If gateway links can be used in remote virtual networking to link to this virtual network.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowVnetAccess
Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases: AllowVirtualNetworkAccess

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Etag
A unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Resource ID.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity
Parameter Sets: CreateViaIdentityExpanded1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the peering.

```yaml
Type: System.String
Parameter Sets: Create1, CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PeeringState
The status of the virtual network peering.
Possible values are 'Initiated', 'Connected', and 'Disconnected'.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.VirtualNetworkPeeringState
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningState
The provisioning state of the resource.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RemoteAddressSpaceAddressPrefix
A list of address blocks reserved for this virtual network in CIDR notation.

```yaml
Type: System.String[]
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RemoteVnetId
Resource ID.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases: RemoteVirtualNetworkId

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UseRemoteGateway
If remote gateways can be used on this virtual network.
If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit.
Only one peering can have this flag set to true.
This flag cannot be set if virtual network already has a gateway.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateViaIdentityExpanded1, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VnetName
The name of the virtual network.

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases: VirtualNetworkName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VnetPeeringName
The name of the peering.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases: VirtualNetworkPeeringName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VnetPeeringParameter
Peerings in a virtual network resource.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IVirtualNetworkPeering
Parameter Sets: Create1, CreateViaIdentity1
Aliases: VirtualNetworkPeeringParameter

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IVirtualNetworkPeering

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IVirtualNetworkPeering

## ALIASES

### New-AzVirtualNetworkPeering

## RELATED LINKS
