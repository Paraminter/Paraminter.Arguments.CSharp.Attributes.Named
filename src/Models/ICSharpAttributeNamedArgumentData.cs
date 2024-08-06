namespace Paraminter.Arguments.CSharp.Attributes.Named.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Associators.Models;

/// <summary>Represents syntactic data about a C# named attribute argument.</summary>
public interface ICSharpAttributeNamedArgumentData
    : IArgumentData
{
    /// <summary>The syntactic data about the C# named attribute argument.</summary>
    public abstract AttributeArgumentSyntax SyntacticArgument { get; }
}
