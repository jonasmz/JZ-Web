namespace JZPortfolio.Common.ValueObjects
{
    public record struct Image(
        string Source,
        string Title,
        string AlternativeDescription,
        bool IsTheCover
    );
}