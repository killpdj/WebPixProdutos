﻿using Entity;
using wpServices;
using System.Threading.Tasks;
using Repository;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DomainBusiness
{
    public static class PropiedadesBO
    {
        /// <summary>
        /// Metodo de salvar Propiedades (Async)
        /// </summary>
        /// <param name="Propiedades"> Objeto Produto</param>
        /// <param name="token"> Token valido</param>
        /// <returns>Verdadeiro: Salvou o Propiedades / Falso: Houve falha</returns>
        public static async Task<bool> SaveAsync(Propiedades Propiedades, string token)
        {
            if (await SeguracaServ.validaTokenAsync(token))
            {
                if (Propiedades.idCliente != 0)
                {

                    //Salva Estrutura
                    try
                    {
                        PropiedadesRep.SaveDept(Propiedades.Departamento);
                    }
                    catch { return false; }

                    //Fim Esstrutura

                    try
                    {
                        PropiedadesRep.SaveArquivos(Propiedades.ArquivosVinculado);

                    }
                    catch { return false; }
                    throw new NotImplementedException();

                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Metodo de retornar todos os Propiedadess por cliente
        /// </summary>
        /// <param name="idCliente">ID do cliente solicitante</param>
        /// <param name="token">Token Valido</param>
        /// <returns></returns>
        public static async Task<List<Propiedades>> GetAllAsync(int idCliente, string token)
        {
            if (await SeguracaServ.validaTokenAsync(token))
                return PropiedadesRep.GetAll().Where(x => x.idCliente == idCliente).ToList();
            else
                return new List<Propiedades>();
        }

        /// <summary>
        /// Metodo de deletar Propiedades
        /// </summary>
        /// <param name="Propiedades">Propiedades que iraser deletado</param>
        /// <param name="token">Token valido</param>
        /// <returns>Verdadeiro: Removeu o Propiedades / Falso: Houve falha</returns>
        public static async Task<bool> RemoveAsync(Object Propiedades, string token)
        {
            dynamic objEn = Propiedades;
            string a = objEn.ID.ToString();
            if (await SeguracaServ.validaTokenAsync(token))
            {
                Propiedades obj = PropiedadesRep.GetAll().Where(x => x.ID == Convert.ToInt32(a)).FirstOrDefault();
                return PropiedadesRep.Remove(obj);
            }
            else
                return false;
        }
    }
}
