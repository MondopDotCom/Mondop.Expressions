namespace Mondop.Expressions
{
    public class VariableDeclarationExpression : Expression
    {
        public string Name { get; set; }
        public TypeReferenceExpression Type { get; set; }
    }
}
