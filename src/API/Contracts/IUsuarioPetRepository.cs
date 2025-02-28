﻿using PetPassBackend.Models;

namespace PetPassBackend.Contracts
{
    public interface IUsuarioPetRepository
    {
        IEnumerable<UsuarioPet> GetAllUsuarioPet();
        IEnumerable<UsuarioPet> GetUsuariosPet(int petId);
        IEnumerable<UsuarioPet> GetPetsUsuario(int usuarioId);
        void CreateUsuarioPet(UsuarioPet usuarioPet);
        void DeleteUsuarioPet(UsuarioPet usuarioPet);

    }
}
