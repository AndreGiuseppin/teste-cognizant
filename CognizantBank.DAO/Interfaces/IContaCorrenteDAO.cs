using CognizantBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CognizantBank.DAO.Interfaces
{
    public interface IContaCorrenteDAO
    {
        List<ContaCorrente> ObterContas();
        void CriarConta(ContaCorrente UI);
        void DebitoCredito(ContaCorrente UI, bool TipoConta);
        void DeletarConta(ContaCorrente UI);
    }
}
