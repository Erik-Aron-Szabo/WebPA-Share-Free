using Npgsql;
using Share_Free;
using Share_Free.Domain;
using Sharing_Free.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharing_Free.Services
{
    public class GroupService : IGroupService
    {

        // rework
        // user joins group
        public void JoinGroup(int userId, int groupId)
        {
            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (
                    var cmd = new NpgsqlCommand(
                        "insert into user_group(user_id, group_id) values(@userId, @groupId)"
                    , conn))
                {
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.Parameters.AddWithValue("groupId", groupId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        // returns the groups the user is in
        public List<UserGroup> UserGroups(int userId)
        {
            List<UserGroup> userGroups = new List<UserGroup>();
            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select distinct u.username, gr.\"name\" from \"group\" as gr inner join user_group as ug on ug.group_id = gr.group_id inner join \"user\" as u on ug.user_id = @userId order by gr.\"name\",  u.username asc; ", conn))
                {
                    cmd.Parameters.AddWithValue("userId", userId);
                    string groupName = "";
                    string userName = "";



                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            groupName = reader["gr.name"].ToString();
                            userName = reader["u.username"].ToString();
                            userGroups.Add(new UserGroup(userName, groupName));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return userGroups;
        }

        // return all groups
        public List<Group> GetAllGroups()
        {
            List<Group> allGroups = new List<Group>();

            using (var conn = new NpgsqlConnection(Program.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select distinct * from \"group\"order by \"name\" asc", conn))
                {

                    int id = 0;
                    string name = "";
                    string username = "";
                    List<string> usernames = new List<string>();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["group_id"]);
                        name = reader["name"].ToString();
                        allGroups.Add(new Group(id, name));
                    }
                }
            }
            return allGroups;
        }
    }
}