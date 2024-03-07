﻿using LMS.DataAccess.Shared;
using LMS.Models.DataModels;
using LMS.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.LectureResource
{
    public class LectureResourceDataService : ILectureResourceDataService
    {
        private string ConnectionString;
        public LectureResourceDataService()
        {
            this.ConnectionString = Configuration.GetDBConfiguration();
        }
        public bool DeleteLectureRoom(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.DeleteLectureResource, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<LectureResourceDBModel> GetLectureResources()
        {
            List<LectureResourceDBModel> lstLectureResources = new List<LectureResourceDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetAllLectureResource, con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    LectureResourceDBModel lectureResource = new LectureResourceDBModel();

                    lectureResource.ID = Convert.ToInt32(rdr["ID"]);
                    lectureResource.Extension = rdr["Extension"].ToString();
                    lectureResource.Resource = Convert.FromBase64String(rdr["Resource"].ToString());
                    lectureResource.CourseID = Convert.ToInt32(rdr["CourseID"].ToString());

                    lstLectureResources.Add(lectureResource);
                }
                con.Close();
            }
            return lstLectureResources;
        }

        public LectureResourceDBModel GetLectureRoom(int id)
        {
            try
            {
                LectureResourceDBModel lectureResource = new LectureResourceDBModel();
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    string sqlQuery = SQLQueries.GetLectureResourceByID + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        lectureResource.ID = Convert.ToInt32(rdr["ID"]);
                        lectureResource.Extension = rdr["Extension"].ToString();
                        lectureResource.Resource = Convert.FromBase64String(rdr["Resource"].ToString());
                        lectureResource.CourseID = Convert.ToInt32(rdr["CourseID"].ToString());
                    }
                }
                return lectureResource;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool InsertLectureResource(LectureResourceDBModel lectureResource)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertLectureResource, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Extension", lectureResource.Extension);
                    cmd.Parameters.AddWithValue("@Resource", lectureResource.Resource);
                    cmd.Parameters.AddWithValue("@CourseID", lectureResource.CourseID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateLectureRoom(LectureResourceDBModel lectureResource)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertLectureResource, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Extension", lectureResource.Extension);
                    cmd.Parameters.AddWithValue("@Resource", lectureResource.Resource);
                    cmd.Parameters.AddWithValue("@CourseID", lectureResource.CourseID);
                    cmd.Parameters.AddWithValue("@ID", lectureResource.ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
