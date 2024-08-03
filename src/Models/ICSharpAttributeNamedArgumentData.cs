namespace Paraminter.Arguments.CSharp.Attributes.Named.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

/// <summary>Represents syntactic data about a C# named attribute argument.</summary>
public interface ICSharpAttributeNamedArgumentData
{
    /// <summary>The syntactic data about the C# named attribute argument.</summary>
    public abstract AttributeArgumentSyntax Argument { get; }
}
