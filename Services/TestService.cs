using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gRPC.Demo.Context;
using gRPC.Demo.Models;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;

namespace gRPC.Demo.Services
{
    public class TestService : Test.TestBase
    {
        private readonly ILogger<TestService> _logger;
        private readonly DBContext _dBContext;
        public TestService(ILogger<TestService> logger,
        DBContext dBContext
        )
        {
            _logger = logger;
            _dBContext = dBContext;
        }
        public override async Task<CreateTestResponse> CreateTest(CreateTestRequest request, ServerCallContext context)
        {
            if (request.Name == string.Empty || request.Description == string.Empty)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "You must provide a valid Name and description"));

            var newItemToBeAdded = new Item
            {
                Name = request.Name,
                Description = request.Description
            };
            await _dBContext.AddAsync(newItemToBeAdded);
            await _dBContext.SaveChangesAsync();
            return await Task.FromResult(new CreateTestResponse
            {
                Id = newItemToBeAdded.Id
            });
        }
        public override async Task<ReadTestResponse> GetTestById(ReadTestRequest request, ServerCallContext context)
        {
            if (request.Id <= 0)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Given Id Should be greater than zero."));

            var returnedItem = await _dBContext.Items.FirstOrDefaultAsync(n => n.Id == request.Id);
            if (returnedItem != null)
            {
                return await Task.FromResult(new ReadTestResponse
                {
                    Id = returnedItem.Id,
                    Name = returnedItem.Name,
                    Description = returnedItem.Description,
                    Status = returnedItem.Status
                });
            }
            throw new RpcException(new Status(StatusCode.NotFound, $"There is no item with such id {request.Id}"));
        }
        public override async Task<GetAllResponse> GetAllTests(GetAllRequest request, ServerCallContext context)
        {
            var response = new GetAllResponse();
            var responseItem = await _dBContext.Items.ToListAsync();
            foreach (var item in responseItem)
            {
                response.Tests.Add(new ReadTestResponse
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Status = item.Status
                });
            }
            return await Task.FromResult(response);
        }
        public override async Task<UpdateTestResponse> UpdateTest(UpdateTestRequest request, ServerCallContext context)
        {
            if (request.Id <= 0 || request.Name == string.Empty || request.Description == string.Empty)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "You should provide a valid Item object"));

            var returnedItem = await _dBContext.Items.FirstOrDefaultAsync(n => n.Id == request.Id) ??
            throw new RpcException(new Status(StatusCode.NotFound, $"There is no item with such id {request.Id}"));

            returnedItem.Name = request.Name;
            returnedItem.Description = request.Description;
            returnedItem.Status = request.Status;

            await _dBContext.SaveChangesAsync();
            return await Task.FromResult(new UpdateTestResponse
            {
                Id = returnedItem.Id
            });
        }
        public override async Task<DeleteTestResponse> DeleteTest(DeleteTestRequest request, ServerCallContext context)
        {
            if (request.Id <= 0)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Given Id Should be greater than zero."));

            var returnedItem = await _dBContext.Items.FirstOrDefaultAsync(n => n.Id == request.Id) ??
            throw new RpcException(new Status(StatusCode.NotFound, $"There is no item with such id {request.Id}"));

            _dBContext.Remove(returnedItem);
            await _dBContext.SaveChangesAsync();
            return await Task.FromResult(new DeleteTestResponse
            {
                Id = returnedItem.Id
            });
        }
    }
}