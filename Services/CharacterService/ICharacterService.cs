using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet6.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacter();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}