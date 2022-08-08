using AutoMapper;
using Cadastro_De_Produtos.Api.Dtos;
using Cadastro_De_Produtos.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Pesquisar_ProdutoController : ControllerBase
    {
        private readonly IPesquisar_ProdutoRepository _pesquisar_ProdutoRepository;
        private readonly IPesquisar_ProdutoService _pesquisar_ProdutoService;
        private readonly IMapper _mapper;


        public Pesquisar_ProdutoController(IPesquisar_ProdutoRepository pesquisarProdutoRepository,
                                           IPesquisar_ProdutoService pesquisar_ProdutoService)
        {
            _pesquisar_ProdutoRepository = pesquisarProdutoRepository;
            _pesquisar_ProdutoService = pesquisar_ProdutoService;
        }

        [HttpGet("{id:guid}")]
        public async Task<Pesquisar_ProdutoDto> ObterPorId(Guid Id)
        {
            return _mapper.Map<Pesquisar_ProdutoDto>(await _pesquisar_ProdutoRepository.ObterPorId(Id));
        }

    }
}