
How to upgrade an existing legacy ASP.NET WebForms app that uses Code Effects 4.x and older:

- Close the project (if it's open in any version of Visual Studio)

- Delete the /bin and /obj folders and .user file from the root of the project (if they exist)

- Open the project in Visual Studio 2017 (older VS versions might need some work to properly support .NET Standard 2.0 necessary for the new Rule Engine)

- Right-click the project in Solution Explorer, select Properties, navigate to Application tab and update project's target framework at least to .NET Framework 4.6.2

- Remove CodeEffects.Rule node from /packages.config file (if exists)

- Remove reference to CodeEffects.Rule.dll from the project

- Add the following NuGet reference:
	- Install-Package CodeEffects.Rule.Editor.Asp (https://www.nuget.org/packages/CodeEffects.Rule.Editor.Asp)

- If the project uses Rule Engine to evaluate rules add the following reference as well:
	- Install-Package CodeEffects.Rule.Engine.Standard.Trial (https://www.nuget.org/packages/CodeEffects.Rule.Engine.Standard.Trial)


- Open /Default.aspx or any other page that declares the Rule Editor and change the value of the "assembly" attribute of the "Register" node on top of each page as follows:
	<%@ Register assembly="CodeEffects.Rule.Editor.Asp" namespace="CodeEffects.Rule.Asp" tagprefix="rule" %>




Dcouemntation:

https://CodeEffects.com/Doc/Business-Rule-Implementation-Example