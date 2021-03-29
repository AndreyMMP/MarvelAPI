using AutoMapper;
using MarvelAPI.Api.Controllers;
using MarvelAPI.Api.ViewModels;
using MarvelAPI.Api.ViewModels.Utils;
using MarvelAPI.Business.Interfaces;
using MarvelAPI.Business.Models;
using MarvelAPI.Test.Fixtures;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MarvelAPI.Test.CharacterControllerTests
{
    [Collection(nameof(CharacterCollection))]
    public partial class CharacterControllerTests
    {
        readonly CharacterTestsFixture _characterTestsFixture;
        public CharacterControllerTests(CharacterTestsFixture characterTestsFixture)
        {
            _characterTestsFixture = characterTestsFixture;
        }
        [Fact]
        public async Task ObterTodos_DeveRetornarTodosPersonagensAsync()
        {            
            //Arrange
            var characterRepository = new Mock<ICharacterRepository>();
            var personagens = new List<Character> { _characterTestsFixture.GerarPersonagem() };
            characterRepository.Setup(s => s.ObterTodosComDetalhes()).ReturnsAsync(personagens);
            var mapper = new Mock<IMapper>();
            CharacterController characterController = new CharacterController(characterRepository.Object, mapper.Object);

            //Act            
            var result = await characterController.ObterTodos();

            //Assert
            Assert.Equal(JsonConvert.SerializeObject(mapper.Object.Map<IEnumerable<CharacterViewModel>>(personagens), Formatting.Indented), result);
        }
        [Fact]
        public async Task ObterTodos_DeveRetornarErro_ExcecaoLancadaAsync()
        {
            //Arrange
            var characterRepository = new Mock<ICharacterRepository>();
            var exMessage = "Erro na camada de negócios.";
            characterRepository.Setup(s => s.ObterTodosComDetalhes()).Throws(new Exception(exMessage));
            var mapper = new Mock<IMapper>();
            CharacterController characterController = new CharacterController(characterRepository.Object, mapper.Object);

            //Act
            var result = await characterController.ObterTodos();

            //Assert
            Assert.Equal(_characterTestsFixture
                .GerarRespostaErrorViewModel(EHttpStatusCode.BadRequest, exMessage, string.Empty), result);
        }
    }
}
