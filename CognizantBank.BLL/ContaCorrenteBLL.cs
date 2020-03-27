using System;
using CognizantBank.BLL.Interfaces;
using System.Collections.Generic;
using CognizantBank.Entities;
using CognizantBank.DAO.Interfaces;

namespace CognizantBank.BLL
{
    public class ContaCorrenteBLL : IContaCorrenteBLL
    {
        private readonly IContaCorrenteDAO contaCorrenteDAO;
        public ContaCorrenteBLL(IContaCorrenteDAO _contaCorrenteDAO)
        {
            contaCorrenteDAO = _contaCorrenteDAO;
        }
        public List<ContaCorrente> ObterContas()
        {
            return contaCorrenteDAO.ObterContas();
        }

        public void CriarConta(ContaCorrente contaCorrente)
        {
            contaCorrenteDAO.CriarConta(contaCorrente);
        }

        public void DebitoCredito(ContaCorrente contaCorrente, bool TipoConta)
        {
            contaCorrenteDAO.DebitoCredito(contaCorrente, TipoConta);
        }

        public void DeletarConta(ContaCorrente contaCorrente)
        {
            contaCorrenteDAO.DeletarConta(contaCorrente);
        }
    }
}
