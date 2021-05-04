// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("NuGet.Frameworks")]
[assembly: AssemblyDescription("NuGet.Frameworks")]
[assembly: AssemblyDefaultAlias("NuGet.Frameworks")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.8.0.6930")]
[assembly: AssemblyInformationalVersion("5.8.0.6930 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.8.0.6930")]




namespace NuGet.Frameworks
{
    public partial class AssetTargetFallbackFramework : NuGet.Frameworks.NuGetFramework, System.IEquatable<NuGet.Frameworks.AssetTargetFallbackFramework>
    {
        public AssetTargetFallbackFramework(NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IList<NuGet.Frameworks.NuGetFramework> fallbackFrameworks) : base (default(NuGet.Frameworks.NuGetFramework)) { }
        public System.Collections.Generic.IList<NuGet.Frameworks.NuGetFramework> Fallback { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework RootFramework { get { throw null; } }
        public NuGet.Frameworks.FallbackFramework AsFallbackFramework() { throw null; }
        public bool Equals(NuGet.Frameworks.AssetTargetFallbackFramework other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public sealed partial class CompatibilityListProvider : NuGet.Frameworks.IFrameworkCompatibilityListProvider
    {
        public CompatibilityListProvider(NuGet.Frameworks.IFrameworkNameProvider nameProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) { }
        public static NuGet.Frameworks.IFrameworkCompatibilityListProvider Default { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetFrameworksSupporting(NuGet.Frameworks.NuGetFramework target) { throw null; }
    }
    public partial class CompatibilityMappingComparer : System.Collections.Generic.IEqualityComparer<NuGet.Frameworks.OneWayCompatibilityMappingEntry>
    {
        public CompatibilityMappingComparer() { }
        public bool Equals(NuGet.Frameworks.OneWayCompatibilityMappingEntry x, NuGet.Frameworks.OneWayCompatibilityMappingEntry y) { throw null; }
        public int GetHashCode(NuGet.Frameworks.OneWayCompatibilityMappingEntry obj) { throw null; }
    }
    public partial class CompatibilityProvider : NuGet.Frameworks.IFrameworkCompatibilityProvider
    {
        public CompatibilityProvider(NuGet.Frameworks.IFrameworkNameProvider mappings) { }
        public bool IsCompatible(NuGet.Frameworks.NuGetFramework target, NuGet.Frameworks.NuGetFramework candidate) { throw null; }
    }
    public partial class CompatibilityTable
    {
        public CompatibilityTable(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { }
        public CompatibilityTable(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks, NuGet.Frameworks.IFrameworkNameProvider mappings, NuGet.Frameworks.IFrameworkCompatibilityProvider compat) { }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetNearest(NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public bool HasFramework(NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public bool TryGetCompatible(NuGet.Frameworks.NuGetFramework framework, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> compatible) { throw null; }
    }
    public sealed partial class DefaultCompatibilityProvider : NuGet.Frameworks.CompatibilityProvider
    {
        public DefaultCompatibilityProvider() : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public static NuGet.Frameworks.IFrameworkCompatibilityProvider Instance { get { throw null; } }
    }
    public sealed partial class DefaultFrameworkMappings : NuGet.Frameworks.IFrameworkMappings
    {
        public DefaultFrameworkMappings() { }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.OneWayCompatibilityMappingEntry> CompatibilityMappings { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> EquivalentFrameworkPrecedence { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<NuGet.Frameworks.NuGetFramework, NuGet.Frameworks.NuGetFramework>> EquivalentFrameworks { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkSpecificMapping> EquivalentProfiles { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<NuGet.Frameworks.NuGetFramework, NuGet.Frameworks.NuGetFramework>> FullNameReplacements { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> IdentifierShortNames { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> IdentifierSynonyms { get { throw null; } }
        public static NuGet.Frameworks.IFrameworkMappings Instance { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> NonPackageBasedFrameworkPrecedence { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> PackageBasedFrameworkPrecedence { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkSpecificMapping> ProfileShortNames { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<NuGet.Frameworks.NuGetFramework, NuGet.Frameworks.NuGetFramework>> ShortNameReplacements { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> SubSetFrameworks { get { throw null; } }
    }
    public sealed partial class DefaultFrameworkNameProvider : NuGet.Frameworks.FrameworkNameProvider
    {
        public DefaultFrameworkNameProvider() : base (default(System.Collections.Generic.IEnumerable<NuGet.Frameworks.IFrameworkMappings>), default(System.Collections.Generic.IEnumerable<NuGet.Frameworks.IPortableFrameworkMappings>)) { }
        public static NuGet.Frameworks.IFrameworkNameProvider Instance { get { throw null; } }
    }
    public partial class DefaultPortableFrameworkMappings : NuGet.Frameworks.IPortableFrameworkMappings
    {
        public DefaultPortableFrameworkMappings() { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, NuGet.Frameworks.FrameworkRange>> CompatibilityMappings { get { throw null; } }
        public static NuGet.Frameworks.IPortableFrameworkMappings Instance { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, NuGet.Frameworks.NuGetFramework[]>> ProfileFrameworks { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, NuGet.Frameworks.NuGetFramework[]>> ProfileOptionalFrameworks { get { throw null; } }
    }
    public partial class FallbackFramework : NuGet.Frameworks.NuGetFramework, System.IEquatable<NuGet.Frameworks.FallbackFramework>
    {
        public FallbackFramework(NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IList<NuGet.Frameworks.NuGetFramework> fallbackFrameworks) : base (default(NuGet.Frameworks.NuGetFramework)) { }
        public System.Collections.Generic.IList<NuGet.Frameworks.NuGetFramework> Fallback { get { throw null; } }
        public bool Equals(NuGet.Frameworks.FallbackFramework other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public static partial class FrameworkConstants
    {
        public static readonly NuGet.Frameworks.FrameworkRange DotNetAll;
        public static readonly System.Version EmptyVersion;
        public static readonly System.Version MaxVersion;
        public static readonly System.Version Version10;
        public static readonly System.Version Version5;
        public static partial class CommonFrameworks
        {
            public static readonly NuGet.Frameworks.NuGetFramework AspNet;
            public static readonly NuGet.Frameworks.NuGetFramework AspNet50;
            public static readonly NuGet.Frameworks.NuGetFramework AspNetCore;
            public static readonly NuGet.Frameworks.NuGetFramework AspNetCore50;
            public static readonly NuGet.Frameworks.NuGetFramework Dnx;
            public static readonly NuGet.Frameworks.NuGetFramework Dnx45;
            public static readonly NuGet.Frameworks.NuGetFramework Dnx451;
            public static readonly NuGet.Frameworks.NuGetFramework Dnx452;
            public static readonly NuGet.Frameworks.NuGetFramework DnxCore;
            public static readonly NuGet.Frameworks.NuGetFramework DnxCore50;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet50;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet51;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet52;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet53;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet54;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet55;
            public static readonly NuGet.Frameworks.NuGetFramework DotNet56;
            public static readonly NuGet.Frameworks.NuGetFramework Net11;
            public static readonly NuGet.Frameworks.NuGetFramework Net2;
            public static readonly NuGet.Frameworks.NuGetFramework Net35;
            public static readonly NuGet.Frameworks.NuGetFramework Net4;
            public static readonly NuGet.Frameworks.NuGetFramework Net403;
            public static readonly NuGet.Frameworks.NuGetFramework Net45;
            public static readonly NuGet.Frameworks.NuGetFramework Net451;
            public static readonly NuGet.Frameworks.NuGetFramework Net452;
            public static readonly NuGet.Frameworks.NuGetFramework Net46;
            public static readonly NuGet.Frameworks.NuGetFramework Net461;
            public static readonly NuGet.Frameworks.NuGetFramework Net462;
            public static readonly NuGet.Frameworks.NuGetFramework Net463;
            public static readonly NuGet.Frameworks.NuGetFramework Net50;
            public static readonly NuGet.Frameworks.NuGetFramework NetCore45;
            public static readonly NuGet.Frameworks.NuGetFramework NetCore451;
            public static readonly NuGet.Frameworks.NuGetFramework NetCore50;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp10;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp11;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp20;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp21;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp22;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp30;
            public static readonly NuGet.Frameworks.NuGetFramework NetCoreApp31;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard10;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard11;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard12;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard13;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard14;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard15;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard16;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard17;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard20;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandard21;
            public static readonly NuGet.Frameworks.NuGetFramework NetStandardApp15;
            public static readonly NuGet.Frameworks.NuGetFramework SL4;
            public static readonly NuGet.Frameworks.NuGetFramework SL5;
            public static readonly NuGet.Frameworks.NuGetFramework Tizen3;
            public static readonly NuGet.Frameworks.NuGetFramework Tizen4;
            public static readonly NuGet.Frameworks.NuGetFramework Tizen6;
            public static readonly NuGet.Frameworks.NuGetFramework UAP10;
            public static readonly NuGet.Frameworks.NuGetFramework Win10;
            public static readonly NuGet.Frameworks.NuGetFramework Win8;
            public static readonly NuGet.Frameworks.NuGetFramework Win81;
            public static readonly NuGet.Frameworks.NuGetFramework WP7;
            public static readonly NuGet.Frameworks.NuGetFramework WP75;
            public static readonly NuGet.Frameworks.NuGetFramework WP8;
            public static readonly NuGet.Frameworks.NuGetFramework WP81;
            public static readonly NuGet.Frameworks.NuGetFramework WPA81;
        }
        public static partial class FrameworkIdentifiers
        {
            public const string AspNet = "ASP.NET";
            public const string AspNetCore = "ASP.NETCore";
            public const string Dnx = "DNX";
            public const string DnxCore = "DNXCore";
            public const string DotNet = "dotnet";
            public const string MonoAndroid = "MonoAndroid";
            public const string MonoMac = "MonoMac";
            public const string MonoTouch = "MonoTouch";
            public const string Native = "native";
            public const string Net = ".NETFramework";
            public const string NetCore = ".NETCore";
            public const string NetCoreApp = ".NETCoreApp";
            public const string NetMicro = ".NETMicroFramework";
            public const string NetPlatform = ".NETPlatform";
            public const string NetStandard = ".NETStandard";
            public const string NetStandardApp = ".NETStandardApp";
            public const string Portable = ".NETPortable";
            public const string Silverlight = "Silverlight";
            public const string Tizen = "Tizen";
            public const string UAP = "UAP";
            public const string Windows = "Windows";
            public const string WindowsPhone = "WindowsPhone";
            public const string WindowsPhoneApp = "WindowsPhoneApp";
            public const string WinRT = "WinRT";
            public const string XamarinIOs = "Xamarin.iOS";
            public const string XamarinMac = "Xamarin.Mac";
            public const string XamarinPlayStation3 = "Xamarin.PlayStation3";
            public const string XamarinPlayStation4 = "Xamarin.PlayStation4";
            public const string XamarinPlayStationVita = "Xamarin.PlayStationVita";
            public const string XamarinTVOS = "Xamarin.TVOS";
            public const string XamarinWatchOS = "Xamarin.WatchOS";
            public const string XamarinXbox360 = "Xamarin.Xbox360";
            public const string XamarinXboxOne = "Xamarin.XboxOne";
        }
        public static partial class PlatformIdentifiers
        {
            public const string Windows = "Windows";
            public const string WindowsPhone = "WindowsPhone";
        }
        public static partial class SpecialIdentifiers
        {
            public const string Agnostic = "Agnostic";
            public const string Any = "Any";
            public const string Unsupported = "Unsupported";
        }
    }
    public partial class FrameworkException : System.Exception
    {
        public FrameworkException(string message) { }
    }
    public partial class FrameworkExpander
    {
        public FrameworkExpander() { }
        public FrameworkExpander(NuGet.Frameworks.IFrameworkNameProvider mappings) { }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> Expand(NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public static partial class FrameworkNameHelpers
    {
        public static string GetFolderName(string identifierShortName, string versionString, string profileShortName) { throw null; }
        public static string GetPortableProfileNumberString(int profileNumber) { throw null; }
        public static System.Version GetVersion(string versionString) { throw null; }
        public static string GetVersionString(System.Version version) { throw null; }
    }
    public partial class FrameworkNameProvider : NuGet.Frameworks.IFrameworkNameProvider
    {
        public FrameworkNameProvider(System.Collections.Generic.IEnumerable<NuGet.Frameworks.IFrameworkMappings> mappings, System.Collections.Generic.IEnumerable<NuGet.Frameworks.IPortableFrameworkMappings> portableMappings) { }
        public void AddFrameworkPrecedenceMappings(System.Collections.Generic.IDictionary<string, int> destination, System.Collections.Generic.IEnumerable<string> mappings) { }
        public int CompareEquivalentFrameworks(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y) { throw null; }
        public int CompareFrameworks(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetCompatibleCandidates() { throw null; }
        public NuGet.Frameworks.NuGetFramework GetFullNameReplacement(NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetNetStandardVersions() { throw null; }
        public NuGet.Frameworks.NuGetFramework GetShortNameReplacement(NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public string GetVersionString(string framework, System.Version version) { throw null; }
        public bool TryGetCompatibilityMappings(NuGet.Frameworks.NuGetFramework framework, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkRange> supportedFrameworkRanges) { throw null; }
        public bool TryGetEquivalentFrameworks(NuGet.Frameworks.FrameworkRange range, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public bool TryGetEquivalentFrameworks(NuGet.Frameworks.NuGetFramework framework, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public bool TryGetIdentifier(string framework, out string identifier) { throw null; }
        public bool TryGetPlatformVersion(string versionString, out System.Version version) { throw null; }
        public bool TryGetPortableCompatibilityMappings(int profile, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkRange> supportedFrameworkRanges) { throw null; }
        public bool TryGetPortableFrameworks(int profile, bool includeOptional, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public bool TryGetPortableFrameworks(int profile, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public bool TryGetPortableFrameworks(string profile, bool includeOptional, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public bool TryGetPortableFrameworks(string shortPortableProfiles, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public bool TryGetPortableProfile(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> supportedFrameworks, out int profileNumber) { throw null; }
        public bool TryGetPortableProfileNumber(string profile, out int profileNumber) { throw null; }
        public bool TryGetProfile(string frameworkIdentifier, string profileShortName, out string profile) { throw null; }
        public bool TryGetShortIdentifier(string identifier, out string identifierShortName) { throw null; }
        public bool TryGetShortProfile(string frameworkIdentifier, string profile, out string profileShortName) { throw null; }
        public bool TryGetSubSetFrameworks(string frameworkIdentifier, out System.Collections.Generic.IEnumerable<string> subSetFrameworks) { throw null; }
        public bool TryGetVersion(string versionString, out System.Version version) { throw null; }
    }
    public partial class FrameworkPrecedenceSorter : System.Collections.Generic.IComparer<NuGet.Frameworks.NuGetFramework>
    {
        public FrameworkPrecedenceSorter(NuGet.Frameworks.IFrameworkNameProvider mappings, bool allEquivalent) { }
        public int Compare(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y) { throw null; }
    }
    public partial class FrameworkRange : System.IEquatable<NuGet.Frameworks.FrameworkRange>
    {
        public FrameworkRange(NuGet.Frameworks.NuGetFramework min, NuGet.Frameworks.NuGetFramework max) { }
        public FrameworkRange(NuGet.Frameworks.NuGetFramework min, NuGet.Frameworks.NuGetFramework max, bool includeMin, bool includeMax) { }
        public string FrameworkIdentifier { get { throw null; } }
        public bool IncludeMax { get { throw null; } }
        public bool IncludeMin { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework Max { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework Min { get { throw null; } }
        public bool Equals(NuGet.Frameworks.FrameworkRange other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool Satisfies(NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FrameworkRangeComparer : System.Collections.Generic.IEqualityComparer<NuGet.Frameworks.FrameworkRange>
    {
        public FrameworkRangeComparer() { }
        public bool Equals(NuGet.Frameworks.FrameworkRange x, NuGet.Frameworks.FrameworkRange y) { throw null; }
        public int GetHashCode(NuGet.Frameworks.FrameworkRange obj) { throw null; }
    }
    public partial class FrameworkReducer
    {
        public FrameworkReducer() { }
        public FrameworkReducer(NuGet.Frameworks.IFrameworkNameProvider mappings, NuGet.Frameworks.IFrameworkCompatibilityProvider compat) { }
        public NuGet.Frameworks.NuGetFramework GetNearest(NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> possibleFrameworks) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> ReduceDownwards(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> ReduceEquivalent(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> ReduceUpwards(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { throw null; }
    }
    public partial class FrameworkRuntimePair : System.IComparable<NuGet.Frameworks.FrameworkRuntimePair>, System.IEquatable<NuGet.Frameworks.FrameworkRuntimePair>
    {
        public FrameworkRuntimePair(NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { }
        public NuGet.Frameworks.NuGetFramework Framework { get { throw null; } }
        public string Name { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } }
        public NuGet.Frameworks.FrameworkRuntimePair Clone() { throw null; }
        public int CompareTo(NuGet.Frameworks.FrameworkRuntimePair other) { throw null; }
        public bool Equals(NuGet.Frameworks.FrameworkRuntimePair other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static string GetName(NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { throw null; }
        public static string GetTargetGraphName(NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FrameworkSpecificMapping
    {
        public FrameworkSpecificMapping(string frameworkIdentifier, System.Collections.Generic.KeyValuePair<string, string> mapping) { }
        public FrameworkSpecificMapping(string frameworkIdentifier, string key, string value) { }
        public string FrameworkIdentifier { get { throw null; } }
        public System.Collections.Generic.KeyValuePair<string, string> Mapping { get { throw null; } }
    }
    public partial interface IFrameworkCompatibilityListProvider
    {
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetFrameworksSupporting(NuGet.Frameworks.NuGetFramework target);
    }
    public partial interface IFrameworkCompatibilityProvider
    {
        bool IsCompatible(NuGet.Frameworks.NuGetFramework framework, NuGet.Frameworks.NuGetFramework other);
    }
    public partial interface IFrameworkMappings
    {
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.OneWayCompatibilityMappingEntry> CompatibilityMappings { get; }
        System.Collections.Generic.IEnumerable<string> EquivalentFrameworkPrecedence { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<NuGet.Frameworks.NuGetFramework, NuGet.Frameworks.NuGetFramework>> EquivalentFrameworks { get; }
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkSpecificMapping> EquivalentProfiles { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<NuGet.Frameworks.NuGetFramework, NuGet.Frameworks.NuGetFramework>> FullNameReplacements { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> IdentifierShortNames { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> IdentifierSynonyms { get; }
        System.Collections.Generic.IEnumerable<string> NonPackageBasedFrameworkPrecedence { get; }
        System.Collections.Generic.IEnumerable<string> PackageBasedFrameworkPrecedence { get; }
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkSpecificMapping> ProfileShortNames { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<NuGet.Frameworks.NuGetFramework, NuGet.Frameworks.NuGetFramework>> ShortNameReplacements { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> SubSetFrameworks { get; }
    }
    public partial interface IFrameworkNameProvider
    {
        int CompareEquivalentFrameworks(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y);
        int CompareFrameworks(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y);
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetCompatibleCandidates();
        NuGet.Frameworks.NuGetFramework GetFullNameReplacement(NuGet.Frameworks.NuGetFramework framework);
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetNetStandardVersions();
        NuGet.Frameworks.NuGetFramework GetShortNameReplacement(NuGet.Frameworks.NuGetFramework framework);
        string GetVersionString(string framework, System.Version version);
        bool TryGetCompatibilityMappings(NuGet.Frameworks.NuGetFramework framework, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkRange> supportedFrameworkRanges);
        bool TryGetEquivalentFrameworks(NuGet.Frameworks.FrameworkRange range, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks);
        bool TryGetEquivalentFrameworks(NuGet.Frameworks.NuGetFramework framework, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks);
        bool TryGetIdentifier(string identifierShortName, out string identifier);
        bool TryGetPlatformVersion(string versionString, out System.Version version);
        bool TryGetPortableCompatibilityMappings(int profile, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkRange> supportedFrameworkRanges);
        bool TryGetPortableFrameworks(int profile, bool includeOptional, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks);
        bool TryGetPortableFrameworks(int profile, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks);
        bool TryGetPortableFrameworks(string profile, bool includeOptional, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks);
        bool TryGetPortableFrameworks(string shortPortableProfiles, out System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks);
        bool TryGetPortableProfile(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> supportedFrameworks, out int profileNumber);
        bool TryGetPortableProfileNumber(string profile, out int profileNumber);
        bool TryGetProfile(string frameworkIdentifier, string profileShortName, out string profile);
        bool TryGetShortIdentifier(string identifier, out string identifierShortName);
        bool TryGetShortProfile(string frameworkIdentifier, string profile, out string profileShortName);
        bool TryGetSubSetFrameworks(string frameworkIdentifier, out System.Collections.Generic.IEnumerable<string> subSetFrameworkIdentifiers);
        bool TryGetVersion(string versionString, out System.Version version);
    }
    public partial interface IFrameworkSpecific
    {
        NuGet.Frameworks.NuGetFramework TargetFramework { get; }
    }
    public partial interface IFrameworkTargetable
    {
        System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> SupportedFrameworks { get; }
    }
    public partial interface IPortableFrameworkMappings
    {
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, NuGet.Frameworks.FrameworkRange>> CompatibilityMappings { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, NuGet.Frameworks.NuGetFramework[]>> ProfileFrameworks { get; }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, NuGet.Frameworks.NuGetFramework[]>> ProfileOptionalFrameworks { get; }
    }
    public partial class NuGetFramework : System.IEquatable<NuGet.Frameworks.NuGetFramework>
    {
        public static readonly NuGet.Frameworks.NuGetFramework AgnosticFramework;
        public static readonly NuGet.Frameworks.NuGetFramework AnyFramework;
        public static readonly System.Collections.Generic.IEqualityComparer<NuGet.Frameworks.NuGetFramework> Comparer;
        public static readonly System.Collections.Generic.IEqualityComparer<NuGet.Frameworks.NuGetFramework> FrameworkNameComparer;
        public static readonly NuGet.Frameworks.NuGetFramework UnsupportedFramework;
        public NuGetFramework(NuGet.Frameworks.NuGetFramework framework) { }
        public NuGetFramework(string framework) { }
        public NuGetFramework(string framework, System.Version version) { }
        public NuGetFramework(string frameworkIdentifier, System.Version frameworkVersion, string frameworkProfile) { }
        public NuGetFramework(string frameworkIdentifier, System.Version frameworkVersion, string platform, System.Version platformVersion) { }
        public bool AllFrameworkVersions { get { throw null; } }
        public string DotNetFrameworkName { get { throw null; } }
        public string DotNetPlatformName { get { throw null; } }
        public string Framework { get { throw null; } }
        public bool HasPlatform { get { throw null; } }
        public bool HasProfile { get { throw null; } }
        public bool IsAgnostic { get { throw null; } }
        public bool IsAny { get { throw null; } }
        public bool IsPackageBased { get { throw null; } }
        public bool IsPCL { get { throw null; } }
        public bool IsSpecificFramework { get { throw null; } }
        public bool IsUnsupported { get { throw null; } }
        public string Platform { get { throw null; } }
        public System.Version PlatformVersion { get { throw null; } }
        public string Profile { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public bool Equals(NuGet.Frameworks.NuGetFramework other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public string GetDotNetFrameworkName(NuGet.Frameworks.IFrameworkNameProvider mappings) { throw null; }
        public override int GetHashCode() { throw null; }
        public string GetShortFolderName() { throw null; }
        public virtual string GetShortFolderName(NuGet.Frameworks.IFrameworkNameProvider mappings) { throw null; }
        public static bool operator ==(NuGet.Frameworks.NuGetFramework left, NuGet.Frameworks.NuGetFramework right) { throw null; }
        public static bool operator !=(NuGet.Frameworks.NuGetFramework left, NuGet.Frameworks.NuGetFramework right) { throw null; }
        public static NuGet.Frameworks.NuGetFramework Parse(string folderName) { throw null; }
        public static NuGet.Frameworks.NuGetFramework Parse(string folderName, NuGet.Frameworks.IFrameworkNameProvider mappings) { throw null; }
        public static NuGet.Frameworks.NuGetFramework ParseComponents(string targetFrameworkMoniker, string targetPlatformMoniker) { throw null; }
        public static NuGet.Frameworks.NuGetFramework ParseFolder(string folderName) { throw null; }
        public static NuGet.Frameworks.NuGetFramework ParseFolder(string folderName, NuGet.Frameworks.IFrameworkNameProvider mappings) { throw null; }
        public static NuGet.Frameworks.NuGetFramework ParseFrameworkName(string frameworkName, NuGet.Frameworks.IFrameworkNameProvider mappings) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class NuGetFrameworkExtensions
    {
        public static T GetNearest<T>(this System.Collections.Generic.IEnumerable<T> items, NuGet.Frameworks.NuGetFramework projectFramework) where T : class, NuGet.Frameworks.IFrameworkSpecific { throw null; }
        public static bool IsDesktop(this NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public partial class NuGetFrameworkFullComparer : System.Collections.Generic.IEqualityComparer<NuGet.Frameworks.NuGetFramework>
    {
        public NuGetFrameworkFullComparer() { }
        public bool Equals(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y) { throw null; }
        public int GetHashCode(NuGet.Frameworks.NuGetFramework obj) { throw null; }
    }
    public partial class NuGetFrameworkNameComparer : System.Collections.Generic.IEqualityComparer<NuGet.Frameworks.NuGetFramework>
    {
        public NuGetFrameworkNameComparer() { }
        public bool Equals(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y) { throw null; }
        public int GetHashCode(NuGet.Frameworks.NuGetFramework obj) { throw null; }
    }
    public partial class NuGetFrameworkSorter : System.Collections.Generic.IComparer<NuGet.Frameworks.NuGetFramework>
    {
        public NuGetFrameworkSorter() { }
        public int Compare(NuGet.Frameworks.NuGetFramework x, NuGet.Frameworks.NuGetFramework y) { throw null; }
    }
    public static partial class NuGetFrameworkUtility
    {
        public static T GetNearest<T>(System.Collections.Generic.IEnumerable<T> items, NuGet.Frameworks.NuGetFramework framework) where T : NuGet.Frameworks.IFrameworkSpecific { throw null; }
        public static T GetNearest<T>(System.Collections.Generic.IEnumerable<T> items, NuGet.Frameworks.NuGetFramework framework, NuGet.Frameworks.IFrameworkNameProvider frameworkMappings, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) where T : NuGet.Frameworks.IFrameworkSpecific { throw null; }
        public static T GetNearest<T>(System.Collections.Generic.IEnumerable<T> items, NuGet.Frameworks.NuGetFramework framework, NuGet.Frameworks.IFrameworkNameProvider frameworkMappings, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider, System.Func<T, NuGet.Frameworks.NuGetFramework> selector) where T : class { throw null; }
        public static T GetNearest<T>(System.Collections.Generic.IEnumerable<T> items, NuGet.Frameworks.NuGetFramework framework, System.Func<T, NuGet.Frameworks.NuGetFramework> selector) where T : class { throw null; }
        public static bool IsCompatibleWithFallbackCheck(NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Frameworks.NuGetFramework candidate) { throw null; }
        public static bool IsNetCore50AndUp(NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public partial class OneWayCompatibilityMappingEntry : System.IEquatable<NuGet.Frameworks.OneWayCompatibilityMappingEntry>
    {
        public OneWayCompatibilityMappingEntry(NuGet.Frameworks.FrameworkRange targetFramework, NuGet.Frameworks.FrameworkRange supportedFramework) { }
        public static NuGet.Frameworks.CompatibilityMappingComparer Comparer { get { throw null; } }
        public NuGet.Frameworks.FrameworkRange SupportedFrameworkRange { get { throw null; } }
        public NuGet.Frameworks.FrameworkRange TargetFrameworkRange { get { throw null; } }
        public bool Equals(NuGet.Frameworks.OneWayCompatibilityMappingEntry other) { throw null; }
        public override string ToString() { throw null; }
    }
}
