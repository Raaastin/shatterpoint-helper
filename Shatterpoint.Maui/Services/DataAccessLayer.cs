﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Model;
using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace Shatterpoint.Maui.Services
{
    public class DataAccessLayer
    {
        /// <summary>
        /// Unit data
        /// </summary>
        public UnitDataBaseService UnitDataBaseService { get; set; }

        public DataAccessLayer(UnitDataBaseService unitDataBaseService)
        {
            UnitDataBaseService = unitDataBaseService;
        }

        /// <summary>
        /// Load all lists
        /// </summary>
        public async Task<List<ListEntity>> LoadLists()
        {
            var result = new List<ListEntity>();

            var path = FileSystem.Current.AppDataDirectory;
            var fileList = Directory.GetFiles(path, "*.json");

            foreach (var file in fileList)
            {
                var fullPath = Path.Combine(path, file);
                var arrayNames = await File.ReadAllTextAsync(fullPath);
                var data = arrayNames.FromJson(UnitDataBaseService);
                result.Add(new ListEntity()
                {
                    ArrayUnit = data,
                    Filename = Path.GetFileNameWithoutExtension(fullPath)
                });
            }

            return result;
        }

        /// <summary>
        /// Save an empty list if not exists;
        /// </summary>
        /// <param name="index"></param>
        public async Task CreateIfNotExists(string filename)
        {
            var path = FileSystem.Current.AppDataDirectory;
            var fullPath = Path.Combine(path, $"{filename}.json");

            if (!File.Exists(fullPath))
            {
                var emptyUnitList = new Unit[6];
                await File.WriteAllTextAsync(fullPath, emptyUnitList.ToJson());
            }
        }

        /// <summary>
        /// Load list by index
        /// </summary>
        /// <param name="index"></param>
        public async Task<ListEntity> LoadList(string filename)
        {
            var path = FileSystem.Current.AppDataDirectory;
            var fullPath = Path.Combine(path, $"{filename}.json");

            var arrayNames = await File.ReadAllTextAsync(fullPath);
            var data = arrayNames.FromJson(UnitDataBaseService);

            var entity = new ListEntity()
            {
                Filename = filename,
                ArrayUnit = data
            };

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listToSave">unit list to save</param>
        /// <param name="index">index of the list</param>
        public async Task SaveList(Unit[] listToSave, string filename)
        {
            var path = FileSystem.Current.AppDataDirectory;
            var fullPath = Path.Combine(path, $"{filename}.json");

            await File.WriteAllTextAsync(fullPath, listToSave.ToJson());
        }

        public void DeleteList(string filename)
        {
            var path = FileSystem.Current.AppDataDirectory;
            var fullPath = Path.Combine(path, $"{filename}.json");
            File.Delete(fullPath);
        }
    }
}
