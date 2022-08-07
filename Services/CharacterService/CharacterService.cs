using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet6.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character{ Id=1, Name = "Mizan" },
            new Character{ Id=2, Name = "Asif" },
            new Character{ Id=3, Name = "Ashique" },
            new Character{ Id=4, Name = "Aiman" },
            new Character{ Id=5, Name = "Ahlan" },
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
             characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacter()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}