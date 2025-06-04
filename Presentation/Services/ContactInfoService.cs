using Presentation.Data.Entities;
using Presentation.Models;
using Presentation.Repositories;

namespace Presentation.Services;

// Created with help from ChatGTP 4.0
public class ContactInfoService(IContactInfoRepository repository)
{
    private readonly IContactInfoRepository _repository = repository;

    public async Task<bool> AddContactInfoAsync(ContactInfoRequest request)
    {
        var entity = new ContactInfoEntity
        {
            UserId = request.UserId,
            ContactTypeId = request.ContactTypeId,
            Value = request.Value
        };

        return await _repository.AddAsync(entity);
    }
}
