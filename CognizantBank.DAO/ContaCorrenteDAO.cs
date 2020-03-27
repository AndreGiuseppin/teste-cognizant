using CognizantBank.DAO.Interfaces;
using CognizantBank.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CognizantBank.DAO
{
    public class ContaCorrenteDAO : ConnectionBase, IContaCorrenteDAO
    {

        //-------------------------------- SELECT CONTA ------------------------------//

        public List<ContaCorrente> ObterContas()
        {
            List<ContaCorrente> listResult = new List<ContaCorrente>();
            MainConn.Open();
            string MyCommand = "select * from ContaCorrente";
            myCommand = new SqlCommand(MyCommand, MainConn);
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                listResult.Add(new ContaCorrente
                {
                    Id = (int)myReader["ID"],
                    CurrentValue = (decimal)myReader["CurrentValue"],
                    MaximumLimit = (decimal)myReader["MaximumLimit"]
                });
            }
            MainConn.Close();
            return listResult;
        }

        //-------------------------------- CRIAR CONTA ------------------------------//

        public void CriarConta(ContaCorrente UI)
        {
            MainConn.Open();
            string myCommand = $@"Insert Into ContaCorrente (CurrentValue, MaximumLimit) values ('{UI.CurrentValue}', '{UI.MaximumLimit}')";
            SqlCommand myCommandCreate = new SqlCommand(myCommand, MainConn);
            myCommandCreate.ExecuteNonQuery();
            MainConn.Close();
        }

        //-------------------------------- UPDATE CONTA ------------------------------//

        public void DebitoCredito (ContaCorrente UI, bool TipoConta)
        {

            MainConn.Open();
            if (TipoConta == false)
            {
                string MyCommand = $@"update ContaCorrente set CurrentValue = CurrentValue - {UI.CurrentValue} where id = {UI.Id}";
                SqlCommand myCommandUpdate1 = new SqlCommand(MyCommand, MainConn);
                myCommandUpdate1.ExecuteNonQuery();
                MainConn.Close();
            }
            if (TipoConta == true)
            {
                string MyCommand = $@"update ContaCorrente set MaximumLimit = MaximumLimit - {UI.CurrentValue} where id = {UI.Id}";
                SqlCommand myCommandUpdate2 = new SqlCommand(MyCommand, MainConn);
                myCommandUpdate2.ExecuteNonQuery();
                MainConn.Close();
            }
        }

        //-------------------------------- DELETAR CONTA ------------------------------//

        public void DeletarConta(ContaCorrente UI)
        {
            MainConn.Open();
            string myCommand = $@"Delete from ContaCorrente where id = {UI.Id}";
            SqlCommand myCommandDelete = new SqlCommand(myCommand, MainConn);
            myCommandDelete.ExecuteNonQuery();
            MainConn.Close();
        }
    }
}
