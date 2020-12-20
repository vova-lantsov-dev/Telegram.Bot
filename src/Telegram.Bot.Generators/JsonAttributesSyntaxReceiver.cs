using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Telegram.Bot.Generators
{
    public class JsonAttributesSyntaxReceiver : ISyntaxReceiver
    {
        public List<TypeDeclarationSyntax> Candidates { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (!(syntaxNode is TypeDeclarationSyntax typeDeclarationSyntax))
                return;

            if (typeDeclarationSyntax.Keyword.ToString() == "record")
                Candidates.Add(typeDeclarationSyntax);
        }
    }
}
