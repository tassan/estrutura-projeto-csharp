using EstanteVirtual.Domain.Core.Entities;
using EstanteVirtual.Tests.Core.Fixtures;
using Xunit.Abstractions;

namespace EstanteVirtual.Tests.Domain.Core;

public class BookTests : IClassFixture<BookFixture>
{
    private readonly BookFixture _fixture;
    private readonly ITestOutputHelper _output;

    public BookTests(BookFixture fixture, ITestOutputHelper output)
    {
        _fixture = fixture;
        _output = output;
    }

    [Fact]
    public void ShouldCreateBook()
    {
        var book = _fixture.CreateBook();
        
        _output.WriteLine(book.ToString());

        book.Should()
            .NotBeNull();

        book.Title.Should()
            .NotBeNullOrEmpty();
    }
    
    // [Fact]
    // public void ShouldCreateBook()
    // {
    //     var book = new Book
    //     {
    //         Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software",
    //         Author = "Eric Evans",
    //         Publisher = "Addison-Wesley Professional",
    //         Year = 2003,
    //         Isbn = "978-0321125217"
    //     };
    //
    //     Assert.Equal("Domain-Driven Design: Tackling Complexity in the Heart of Software", book.Title);
    //     Assert.Equal("Eric Evans", book.Author);
    //     Assert.Equal("Addison-Wesley Professional", book.Publisher);
    //     Assert.Equal(2003, book.Year);
    //     Assert.Equal("978-0321125217", book.Isbn);
    // }
}