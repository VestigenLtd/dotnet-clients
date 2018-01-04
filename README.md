Clients
=======

AppVeyor: Coming Soon

Travis:   Coming Soon

Clients is a set of individually developed and maintained clients for various remote systems and protocols.

Overview
--------

This framework follows a similar architectual model as the `Microsoft.Extensions.*` NuGet packages that are owned and maintained by the Microsoft ASP.NET team.

This particular respository is a **proprietary** solution for which there are no upstream packages on which it's built. 

Packages
--------

The vision for this framework is to maintain framework compatibility for `netstandard1.4` and `netstandard2.0` as much as possible. This is only possible if the underlying libraries maintain support for these same framework versions and may/may not follow this vision. Any exceptions to this rule will be noted below in the package list. For more information on framework version targeting, please see [this document](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

The packages are published with unsigned assemblies.

The packages produced from this repository are as follows:

- Vestigen.Clients.HashiCorp.Vault
- Vestigen.Clients.HashiCorp.Consul

Samples
-------

See `samples/ConsoleApp` as an example of how to implement the package.