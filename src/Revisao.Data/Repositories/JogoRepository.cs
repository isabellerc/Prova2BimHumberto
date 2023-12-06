using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;
using Revisao.Data.Providers.MongoDB.Interfaces;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class JogoRepository : IRegistroJogoRepository
    {
        private readonly IMongoRepository<JogosCollection> _JogosRepository;

        private readonly IMapper _Mapper;
        public JogoRepository(IMongoRepository<JogosCollection> JogoRepository, IMapper mapper)
        {
            _JogosRepository = JogoRepository;
            _Mapper = mapper;

        }

        public async Task Adicionar(RegistroJogo registroJogo)
        {
            await _JogosRepository.InsertOneAsync(_Mapper.Map<JogosCollection>(registroJogo));

        }


        public IEnumerable<RegistroJogo> ObterTodos()
        {
            var CartaList = _JogosRepository.FilterBy(filter => true);
            return _Mapper.Map<IEnumerable<RegistroJogo>>(CartaList);
        }

        public Task<IEnumerable<RegistroJogo>> ObterTodosOsJogos()
        {
            throw new NotImplementedException();
        }

        public Task RegistrarJogo(RegistroJogo registroJogo)
        {
            throw new NotImplementedException();
        }

        //private List<DocumentosCarta> LerCartaDoArquivo()
        //{
        //    if (!System.IO.File.Exists(_CartaCaminhoArquivo))
        //        return new List<DocumentosCarta>();
        //    string json = System.IO.File.ReadAllText(_CartaCaminhoArquivo);
        //    return JsonConvert.DeserializeObject<List<DocumentosCarta>>(json);
        //}

        //private void EscreverCartaNoArquivo(List<DocumentosCarta> documentosCarta)
        //{
        //    string json = JsonConvert.SerializeObject(documentosCarta);
        //    System.IO.File.WriteAllText(_CartaCaminhoArquivo, json);
        //}
    }
}
