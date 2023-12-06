using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
	public interface IRegistroJogoService
	{
        IEnumerable<RegistroJogoViewModel> ObterTodos();
        public Task RegistrarJogo(NovoRegistroJogoViewModel registroJogoViewModel);

       
    }
}
