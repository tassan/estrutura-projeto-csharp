namespace EstanteVirtual.Tests.Core.Fixtures;

public class BookFixture
{
    public Book CreateBook()
    {
        var faker = new Faker<Book>()
            .RuleFor(b => b.Title, f => f.Lorem.Sentence())
            .RuleFor(b => b.Author, f => f.Person.FullName)
            .RuleFor(b => b.Publisher, f => f.Company.CompanyName())
            .RuleFor(b => b.Year, f => f.Random.Int(1900, 2021))
            .RuleFor(b => b.Isbn, f => f.Random.Replace("###-##-#####-##-#"));

        return faker.Generate();
    }
}