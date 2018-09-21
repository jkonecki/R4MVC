using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R4Mvc.Tools.CodeGen;

namespace R4Mvc.Tools.Services
{
    public interface IControllerGeneratorService
    {
        string GetControllerArea(INamedTypeSymbol controllerSymbol);
        ClassDeclarationSyntax GeneratePartialController(ControllerDefinition controller);
        ClassDeclarationSyntax GenerateR4Controller(ControllerDefinition controller);
        ClassBuilder WithViewsClass(ClassBuilder classBuilder, IEnumerable<IView> viewFiles);
    }
}
