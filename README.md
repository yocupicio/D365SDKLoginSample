# D365SDKLoginSample
Using XRM tooling common login control for WPF Applications in a Windows Form client applications
Sometimes there is a requirement from business to create windows form applications that perform some actions to Dynamics 365.
There are certain pains when we need to store connection information or connection fails because Multifactor Authentication (MFA).
There is a Common login control available in SDK that allow you to choose the authentication method to connect to Dynamics 365 On-Premise or Online. 
Common login control is a WPF user control that provides a common user interface for the sign in experience to Common Data Service. The login control provides support for all the authentication modes that are supported by Common Data Service. The common login control has built-in encryption for securely storing your credentials/profile, and then reusing it at runtime to automatically sign in to Common Data Service. The namespace for this component is Microsoft.Xrm.Tooling.CrmConnectControl.

