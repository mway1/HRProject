using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class CommentManager
    {
        public List<CommentDTO> GetAllComment()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<CommentDTO>(
                    CommentStoredProcedures.Comment_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
        public void AddComment(CommentDTO newComment)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<CommentDTO>(
                     CommentStoredProcedures.Comment_add,
                     param: new
                     {
                         newComment.Description,
                         newComment.EmployeeId,
                         newComment.isDeleted
                     },
                     commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void DeleteCommentById(int commentId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                connection.QuerySingleOrDefault<CommentDTO>(
                    CommentStoredProcedures.Comment_Delete,
                    param: new { id = commentId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
    }
}
