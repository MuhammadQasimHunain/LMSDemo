﻿using LMS.DataAccess.Shared;
using LMS.DataAccess.DataModels;
using LMS.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.LectureRoom
{
    public class LectureRoomDataLayer : ILectureRoomDataLayer
    {
        private string ConnectionString;
        public LectureRoomDataLayer()
        {
            this.ConnectionString = Configuration.GetDBConfiguration();
        }
        public bool DeleteLectureRoom(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.DeleteLectureRoom, con);
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

        public LectureRoomDBModel GetLectureRoom(int id)
        {
            try
            {
                LectureRoomDBModel lectureRoom = new LectureRoomDBModel();
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    string sqlQuery = SQLQueries.GetLectureRoomByID.Replace("@ID",id.ToString());
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        lectureRoom.ID = Convert.ToInt32(rdr["ID"]);
                        lectureRoom.Name = rdr["Name"].ToString();
                        lectureRoom.Capaicty = Convert.ToInt32(rdr["Capaicty"]);
                    }
                }
                return lectureRoom;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<LectureRoomDBModel> GetLectureRoom()
        {
            List<LectureRoomDBModel> lstLectureRooms = new List<LectureRoomDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetAllLectureRoom, con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    LectureRoomDBModel lectureRoom = new LectureRoomDBModel();

                    lectureRoom.ID = Convert.ToInt32(rdr["ID"]);
                    lectureRoom.Name = rdr["Name"].ToString();
                    lectureRoom.Capaicty = Convert.ToInt32(rdr["Capaicty"]);

                    lstLectureRooms.Add(lectureRoom);
                }
                con.Close();
            }
            return lstLectureRooms;
        }

        public bool InsertLectureRoom(LectureRoomDBModel lectureRoom)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertLectureRoom, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Name", lectureRoom.Name);
                    cmd.Parameters.AddWithValue("@Capaicty", lectureRoom.Capaicty);
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

        public bool UpdateLectureRoom(LectureRoomDBModel lectureRoom)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertLectureRoom, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Name", lectureRoom.Name);
                    cmd.Parameters.AddWithValue("@ID", lectureRoom.ID);
                    cmd.Parameters.AddWithValue("@Capaicty", lectureRoom.Capaicty);

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