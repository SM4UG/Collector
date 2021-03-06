﻿using System.Collections.Generic;
using Collector.Models.Home;
using DLToolkit.Forms.Controls;
using Newtonsoft.Json;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Collector.Models.Usuarios
{
    [Table("Users")]
    public class UserModel
    {
        [JsonIgnore]
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JsonIgnore]
        public string Name { get; set; }

        [JsonIgnore]
        public string NickName { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [JsonIgnore]
        public string Image { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("localidade")]
        public string City { get; set; }

        [JsonProperty("logradouro")]
        public string Road { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonIgnore]
        public string HouseNumber { get; set; }

        [JsonIgnore]
        public string Summary { get; set; }

        [JsonIgnore]
        public string History { get; set; }

        [JsonIgnore]
        public string Phone { get; set; }

        [JsonIgnore]
        public bool Details { get; set; }

        [JsonIgnore]
        public bool IsCollector { get; set; }

        [JsonIgnore]
        public bool Term { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<MateriaisModel> CollectorItens { get; set; }

        [Ignore]
        public FlowObservableCollection<MateriaisModel> CollectorItemsView { get; set; } = new FlowObservableCollection<MateriaisModel>();

    }
}
