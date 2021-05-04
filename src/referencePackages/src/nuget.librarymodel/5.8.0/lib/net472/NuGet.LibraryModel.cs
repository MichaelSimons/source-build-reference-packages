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
[assembly: AssemblyTitle("NuGet.LibraryModel")]
[assembly: AssemblyDescription("NuGet.LibraryModel")]
[assembly: AssemblyDefaultAlias("NuGet.LibraryModel")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.8.0.6930")]
[assembly: AssemblyInformationalVersion("5.8.0.6930 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.8.0.6930")]




namespace NuGet.LibraryModel
{
    public sealed partial class CentralPackageVersion : System.IEquatable<NuGet.LibraryModel.CentralPackageVersion>
    {
        public CentralPackageVersion(string name, NuGet.Versioning.VersionRange versionRange) { }
        public string Name { get { throw null; } }
        public NuGet.Versioning.VersionRange VersionRange { get { throw null; } }
        public bool Equals(NuGet.LibraryModel.CentralPackageVersion other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class CentralPackageVersionNameComparer : System.Collections.Generic.IEqualityComparer<NuGet.LibraryModel.CentralPackageVersion>
    {
        internal CentralPackageVersionNameComparer() { }
        public static NuGet.LibraryModel.CentralPackageVersionNameComparer Default { get { throw null; } }
        public bool Equals(NuGet.LibraryModel.CentralPackageVersion x, NuGet.LibraryModel.CentralPackageVersion y) { throw null; }
        public int GetHashCode(NuGet.LibraryModel.CentralPackageVersion obj) { throw null; }
    }
    public partial class DownloadDependency : System.IComparable<NuGet.LibraryModel.DownloadDependency>, System.IEquatable<NuGet.LibraryModel.DownloadDependency>
    {
        public DownloadDependency(string name, NuGet.Versioning.VersionRange versionRange) { }
        public string Name { get { throw null; } }
        public NuGet.Versioning.VersionRange VersionRange { get { throw null; } }
        public NuGet.LibraryModel.DownloadDependency Clone() { throw null; }
        public int CompareTo(NuGet.LibraryModel.DownloadDependency other) { throw null; }
        public bool Equals(NuGet.LibraryModel.DownloadDependency other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static implicit operator NuGet.LibraryModel.LibraryRange (NuGet.LibraryModel.DownloadDependency library) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class FrameworkDependency : System.IComparable<NuGet.LibraryModel.FrameworkDependency>, System.IEquatable<NuGet.LibraryModel.FrameworkDependency>
    {
        public FrameworkDependency(string name, NuGet.LibraryModel.FrameworkDependencyFlags privateAssets) { }
        public string Name { get { throw null; } }
        public NuGet.LibraryModel.FrameworkDependencyFlags PrivateAssets { get { throw null; } }
        public int CompareTo(NuGet.LibraryModel.FrameworkDependency other) { throw null; }
        public bool Equals(NuGet.LibraryModel.FrameworkDependency other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.FlagsAttribute]
    public enum FrameworkDependencyFlags : ushort
    {
        All = (ushort)65535,
        None = (ushort)0,
    }
    public partial class FrameworkDependencyFlagsUtils
    {
        public static readonly NuGet.LibraryModel.FrameworkDependencyFlags Default;
        public FrameworkDependencyFlagsUtils() { }
        public static NuGet.LibraryModel.FrameworkDependencyFlags GetFlags(System.Collections.Generic.IEnumerable<string> values) { throw null; }
        public static NuGet.LibraryModel.FrameworkDependencyFlags GetFlags(string flags) { throw null; }
        public static string GetFlagString(NuGet.LibraryModel.FrameworkDependencyFlags flags) { throw null; }
    }
    public static partial class KnownLibraryProperties
    {
        public static readonly string AssemblyPath;
        public static readonly string FrameworkAssemblies;
        public static readonly string FrameworkReferences;
        public static readonly string LockFileLibrary;
        public static readonly string LockFileTargetLibrary;
        public static readonly string MSBuildProjectPath;
        public static readonly string PackageSpec;
        public static readonly string ProjectFrameworks;
        public static readonly string ProjectRestoreMetadataFiles;
        public static readonly string ProjectStyle;
        public static readonly string TargetFrameworkInformation;
    }
    public partial class Library
    {
        public static readonly System.Collections.Generic.IEqualityComparer<NuGet.LibraryModel.Library> IdentityComparer;
        public Library() { }
        public System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> Dependencies { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryIdentity Identity { get { throw null; } set { } }
        public object this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, object> Items { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryRange LibraryRange { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public bool Resolved { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class LibraryDependency : System.IEquatable<NuGet.LibraryModel.LibraryDependency>
    {
        public LibraryDependency() { }
        [System.ObsoleteAttribute]
        public LibraryDependency(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.LibraryModel.LibraryDependencyType type, NuGet.LibraryModel.LibraryIncludeFlags includeType, NuGet.LibraryModel.LibraryIncludeFlags suppressParent, System.Collections.Generic.IList<NuGet.Common.NuGetLogCode> noWarn, bool autoReferenced, bool generatePathProperty) { }
        [System.ObsoleteAttribute]
        public LibraryDependency(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.LibraryModel.LibraryDependencyType type, NuGet.LibraryModel.LibraryIncludeFlags includeType, NuGet.LibraryModel.LibraryIncludeFlags suppressParent, System.Collections.Generic.IList<NuGet.Common.NuGetLogCode> noWarn, bool autoReferenced, bool generatePathProperty, bool versionCentrallyManaged, NuGet.LibraryModel.LibraryDependencyReferenceType libraryDependencyReferenceType) { }
        public string Aliases { get { throw null; } set { } }
        public bool AutoReferenced { get { throw null; } set { } }
        public bool GeneratePathProperty { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryIncludeFlags IncludeType { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryRange LibraryRange { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Common.NuGetLogCode> NoWarn { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryDependencyReferenceType ReferenceType { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryIncludeFlags SuppressParent { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryDependencyType Type { get { throw null; } set { } }
        public bool VersionCentrallyManaged { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryDependency Clone() { throw null; }
        public bool Equals(NuGet.LibraryModel.LibraryDependency other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool HasFlag(NuGet.LibraryModel.LibraryDependencyTypeFlag flag) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LibraryDependencyInfo
    {
        public LibraryDependencyInfo(NuGet.LibraryModel.LibraryIdentity library, bool resolved, NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> dependencies) { }
        public System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> Dependencies { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework Framework { get { throw null; } }
        public NuGet.LibraryModel.LibraryIdentity Library { get { throw null; } }
        public bool Resolved { get { throw null; } }
        public static NuGet.LibraryModel.LibraryDependencyInfo Create(NuGet.LibraryModel.LibraryIdentity library, NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> dependencies) { throw null; }
        public static NuGet.LibraryModel.LibraryDependencyInfo CreateUnresolved(NuGet.LibraryModel.LibraryIdentity library, NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public enum LibraryDependencyReferenceType
    {
        Direct = 2,
        None = 0,
        Transitive = 1,
    }
    [System.FlagsAttribute]
    public enum LibraryDependencyTarget : ushort
    {
        All = (ushort)63,
        Assembly = (ushort)8,
        ExternalProject = (ushort)4,
        None = (ushort)0,
        Package = (ushort)1,
        PackageProjectExternal = (ushort)7,
        Project = (ushort)2,
        Reference = (ushort)16,
        WinMD = (ushort)32,
    }
    public partial class LibraryDependencyTargetUtils
    {
        public LibraryDependencyTargetUtils() { }
        public static string GetFlagString(NuGet.LibraryModel.LibraryDependencyTarget flags) { throw null; }
        public static NuGet.LibraryModel.LibraryDependencyTarget Parse(string flag) { throw null; }
    }
    public partial class LibraryDependencyType : System.IEquatable<NuGet.LibraryModel.LibraryDependencyType>
    {
        public static NuGet.LibraryModel.LibraryDependencyType Build;
        public static NuGet.LibraryModel.LibraryDependencyType Default;
        public static NuGet.LibraryModel.LibraryDependencyType Platform;
        public LibraryDependencyType() { }
        public NuGet.LibraryModel.LibraryDependencyType Combine(System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependencyTypeFlag> add, System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependencyTypeFlag> remove) { throw null; }
        public bool Contains(NuGet.LibraryModel.LibraryDependencyTypeFlag flag) { throw null; }
        public bool Equals(NuGet.LibraryModel.LibraryDependencyType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static NuGet.LibraryModel.LibraryDependencyType Parse(System.Collections.Generic.IEnumerable<string> keywords) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LibraryDependencyTypeFlag
    {
        internal LibraryDependencyTypeFlag() { }
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag BecomesNupkgDependency;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag DevComponent;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag MainExport;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag MainReference;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag MainSource;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag PreprocessComponent;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag PreprocessReference;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag RuntimeComponent;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeFlag SharedFramework;
        public static NuGet.LibraryModel.LibraryDependencyTypeFlag Declare(string keyword) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LibraryDependencyTypeKeyword
    {
        internal LibraryDependencyTypeKeyword() { }
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeKeyword Build;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeKeyword Default;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeKeyword Dev;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeKeyword Platform;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeKeyword Preprocess;
        public static readonly NuGet.LibraryModel.LibraryDependencyTypeKeyword Private;
        public System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependencyTypeFlag> FlagsToAdd { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependencyTypeFlag> FlagsToRemove { get { throw null; } }
        public NuGet.LibraryModel.LibraryDependencyType CreateType() { throw null; }
    }
    public static partial class LibraryExtensions
    {
        public static T GetItem<T>(this NuGet.LibraryModel.Library library, string key) { throw null; }
        public static T GetRequiredItem<T>(this NuGet.LibraryModel.Library library, string key) { throw null; }
        public static bool IsEclipsedBy(this NuGet.LibraryModel.LibraryRange library, NuGet.LibraryModel.LibraryRange other) { throw null; }
    }
    public partial class LibraryIdentity : System.IComparable<NuGet.LibraryModel.LibraryIdentity>, System.IEquatable<NuGet.LibraryModel.LibraryIdentity>
    {
        public LibraryIdentity() { }
        public LibraryIdentity(string name, NuGet.Versioning.NuGetVersion version, NuGet.LibraryModel.LibraryType type) { }
        public string Name { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryType Type { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } set { } }
        public int CompareTo(NuGet.LibraryModel.LibraryIdentity other) { throw null; }
        public bool Equals(NuGet.LibraryModel.LibraryIdentity other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(NuGet.LibraryModel.LibraryIdentity left, NuGet.LibraryModel.LibraryIdentity right) { throw null; }
        public static implicit operator NuGet.LibraryModel.LibraryRange (NuGet.LibraryModel.LibraryIdentity library) { throw null; }
        public static bool operator !=(NuGet.LibraryModel.LibraryIdentity left, NuGet.LibraryModel.LibraryIdentity right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum LibraryIncludeFlags : ushort
    {
        All = (ushort)127,
        Analyzers = (ushort)32,
        Build = (ushort)4,
        BuildTransitive = (ushort)64,
        Compile = (ushort)2,
        ContentFiles = (ushort)16,
        Native = (ushort)8,
        None = (ushort)0,
        Runtime = (ushort)1,
    }
    public partial class LibraryIncludeFlagUtils
    {
        public static readonly NuGet.LibraryModel.LibraryIncludeFlags DefaultSuppressParent;
        public static readonly NuGet.LibraryModel.LibraryIncludeFlags NoContent;
        public LibraryIncludeFlagUtils() { }
        public static NuGet.LibraryModel.LibraryIncludeFlags GetFlags(System.Collections.Generic.IEnumerable<string> flags) { throw null; }
        public static NuGet.LibraryModel.LibraryIncludeFlags GetFlags(string flags, NuGet.LibraryModel.LibraryIncludeFlags defaultFlags) { throw null; }
        public static string GetFlagString(NuGet.LibraryModel.LibraryIncludeFlags flags) { throw null; }
    }
    public partial class LibraryRange : System.IEquatable<NuGet.LibraryModel.LibraryRange>
    {
        public LibraryRange() { }
        public LibraryRange(string name, NuGet.LibraryModel.LibraryDependencyTarget typeConstraint) { }
        public LibraryRange(string name, NuGet.Versioning.VersionRange versionRange, NuGet.LibraryModel.LibraryDependencyTarget typeConstraint) { }
        public string Name { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryDependencyTarget TypeConstraint { get { throw null; } set { } }
        public NuGet.Versioning.VersionRange VersionRange { get { throw null; } set { } }
        public bool Equals(NuGet.LibraryModel.LibraryRange other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(NuGet.LibraryModel.LibraryRange left, NuGet.LibraryModel.LibraryRange right) { throw null; }
        public static bool operator !=(NuGet.LibraryModel.LibraryRange left, NuGet.LibraryModel.LibraryRange right) { throw null; }
        public string ToLockFileDependencyGroupString() { throw null; }
        public override string ToString() { throw null; }
        public bool TypeConstraintAllows(NuGet.LibraryModel.LibraryDependencyTarget flag) { throw null; }
        public bool TypeConstraintAllowsAnyOf(NuGet.LibraryModel.LibraryDependencyTarget flag) { throw null; }
    }
    public partial struct LibraryType : System.IEquatable<NuGet.LibraryModel.LibraryType>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public static readonly NuGet.LibraryModel.LibraryType Assembly;
        public static readonly NuGet.LibraryModel.LibraryType ExternalProject;
        public static readonly NuGet.LibraryModel.LibraryType Package;
        public static readonly NuGet.LibraryModel.LibraryType Project;
        public static readonly NuGet.LibraryModel.LibraryType Reference;
        public static readonly NuGet.LibraryModel.LibraryType Unresolved;
        public static readonly NuGet.LibraryModel.LibraryType WinMD;
        public bool IsKnown { get { throw null; } }
        public string Value { get { throw null; } }
        public bool Equals(NuGet.LibraryModel.LibraryType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(NuGet.LibraryModel.LibraryType left, NuGet.LibraryModel.LibraryType right) { throw null; }
        public static implicit operator string (NuGet.LibraryModel.LibraryType libraryType) { throw null; }
        public static bool operator !=(NuGet.LibraryModel.LibraryType left, NuGet.LibraryModel.LibraryType right) { throw null; }
        public static NuGet.LibraryModel.LibraryType Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
}
