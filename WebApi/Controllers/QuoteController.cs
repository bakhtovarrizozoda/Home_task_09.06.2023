using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class QuoteController : ControllerBase
{
    private readonly QuoteService _quoteService;

    public QuoteController(QuoteService quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet("GetQuotes")]
    public async Task<List<Quote>> GetQuote()
    {
        return await _quoteService.GetQuote();
    }

    [HttpGet("GetQuoteById")]
    public async Task<Quote> GetQuoteById(int Id)
    {
        return await _quoteService.GetQuoteById(Id);
    }

    [HttpPost("AddQuote")]
    public async Task<Quote> AddQuote(Quote quote)
    {
        return await _quoteService.AddQuote(quote);
    }

    [HttpPut("UpdateQuote")]
    public async Task<Quote> UpdateQuote(Quote quote)
    {
        return await _quoteService.UpdateQuote(quote);
    }

    [HttpDelete("DeleteQuote")]
    public async Task<bool> DeleteQuote(int Id)
    {
        return await _quoteService.DeleteQuote(Id); 
    }
}