using CognizantBank.Entities;
using System.Collections.Generic;

namespace CognizantBank.BLL.Interfaces
{
    public interface IContaCorrenteBLL
    {
        List<ContaCorrente> ObterContas();
        void CriarConta(ContaCorrente contaCorrente);
        void DebitoCredito(ContaCorrente contaCorrente, bool TipoConta);
        void DeletarConta(ContaCorrente contaCorrente);
    }
}

