﻿namespace Estoque.Api.Data.Interface;

public interface IRepository<TEntity> 
{
    IQueryable<TEntity> BuscarTodos();
    int Salvar();
    void Adicionar(TEntity obj);
    void Atualizar(TEntity obj);
}