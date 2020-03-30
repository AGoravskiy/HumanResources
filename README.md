# HumanResources

It is a Web Application designed to view a list of employees and candidates. 

Technologies used: ASP.NET Web Api, Entity Framework, React.

# Building and Running the App

1. To build the Web API project, open the solution in Visual Studio, and build the solution to install Nuget packages. This will automatically restore Nuget packages.
2. If you haven't installed Node.js, download and install it from http://nodejs.org/
3. Go to **Properties** of solution and and set **Multiple startup projects**. Choose **Action** **Start** for WebApi and WebReact.
4. **Start**.

# If you get error on WebApi: Could not find a part of the path "...\bin\roslyn\csc.exe"

Add this code in WebApi **.csproj** file:

```xml
<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>
```
