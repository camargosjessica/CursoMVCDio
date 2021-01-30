using CursoAPI.Controllers;
using CursoMVCDio.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTest
{
    public class CategoriasControllerTest
     {
        private readonly Mock<Microsoft.EntityFrameworkCore.DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<Microsoft.EntityFrameworkCore.DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, Descricao = "Teste Categoria" };
            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.GetCategoria(id:1);

            _mockSet.Verify(expression:m => m.FindAsync(1),
                Times.Once());
        }
    }
}
