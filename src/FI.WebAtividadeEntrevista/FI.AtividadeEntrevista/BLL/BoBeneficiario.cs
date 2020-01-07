using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario 
    {
        /// <summary>
        /// Inclui um novo beneficiario
        /// </summary>
        /// <param name="beneficiario">Objeto de beneficiario</param>
        public long Incluir(DML.Beneficiario beneficiario)
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            return benef.Incluir(beneficiario);
        }

        /// <summary>
        /// Altera um cliente
        /// </summary>
        /// <param name="beneficiario">Objeto de cliente</param>
        public void Alterar(DML.Beneficiario beneficiario)
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            benef.Alterar(beneficiario);
        }

        /// <summary>
        /// Consulta o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public DML.Beneficiario Consultar(long id)
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            return benef.Consultar(id);
        }

        /// <summary>
        /// Excluir o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            benef.Excluir(id);
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Beneficiario> Listar()
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            return benef.Listar();
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Beneficiario> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            return benef.Pesquisa(iniciarEm, quantidade, campoOrdenacao, crescente, out qtd);
        }

        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF)
        {
            DAL.DoaBeneficiario benef = new DAL.DoaBeneficiario();
            return benef.VerificarExistencia(CPF);
        }
    }
}
