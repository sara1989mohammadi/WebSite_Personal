using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookService: IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(Book book)
        {
            return await _unitOfWork.Book.AddAsync(book);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.Book.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<Book>> GetAll()
        {
            return await _unitOfWork.Book.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<Book> GetById(int id)
        {
            return await _unitOfWork.Book.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(Book book)
        {
            return await _unitOfWork.Book.UpdateAsync(book);
            _unitOfWork.Execute();
        }
    }
}
