using LMS.DataAccess.Shared;
using LMS.Models.DataModels;
using LMS.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.LectureRoom
{
    public class LectureRoomDataService : ILectureRoomDataService
    {
        private string ConnectionString;
        public LectureRoomDataService()
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
                    string sqlQuery = SQLQueries.GetLectureRoomByID + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        lectureRoom.ID = Convert.ToInt32(rdr["ID"]);
                        lectureRoom.Name = rdr["Name"].ToString();
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
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    LectureRoomDBModel lectureRoom = new LectureRoomDBModel();

                    lectureRoom.ID = Convert.ToInt32(rdr["ID"]);
                    lectureRoom.Name = rdr["Extension"].ToString();

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
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", lectureRoom.Name);

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
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", lectureRoom.Name);
                    cmd.Parameters.AddWithValue("@ID", lectureRoom.ID);

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
