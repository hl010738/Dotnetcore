using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Model
{
    [TableName("Users")]
    [PrimaryKey("Id", SequenceName = "SEQ_USER")]
    public class Users
    {
        [Column("ID")]
        public long Id { get; set; }

        [Column("NAME")]
        public String Name { get; set; }

        public Users(){ }

        public Users(String name)
        {
            this.Name = name;
        }
    }
}
