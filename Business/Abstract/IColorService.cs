﻿using System.Collections.Generic;
using Entities;

namespace Business
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}