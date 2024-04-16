﻿using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{

    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {

        public PayModeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModel> GetByValues(string values)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<PayModeModel> Getall()
        {
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }
            return payModeList;

            
        }
        public IEnumerable<PayModeModel> GetByValue(string values)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(values, out _) ? Convert.ToInt32(values) : 0;
            string payModeName = values;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM paymode 
                           WHERE Pay_Mode_Id=@id or Pay_Mode_Name LIKE @name+ '%'
                           ORDER By Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Model_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }
            return payModeList;

        }
    }
}
