﻿/*******************************************************************************
* 命名空间: SF.Core.Abstraction.UoW
*
* 功 能： N/A
* 类 名： IRepository
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2016/11/11 10:35:30 疯狂蚂蚁 初版
*
* Copyright (c) 2016 SF 版权所有
* Description: SF快速开发平台
* Website：http://www.mayisite.com
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SF.Core.Abstraction.UoW
{
    /// <summary>
    /// Repository interface that will be used to query and manipulate
    /// persisted entities
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TId">The entity id type</typeparam>
    public interface IRepository<TEntity, in TId> : IAsyncRepository<TEntity, TId>, ISyncRepository<TEntity, TId>
        where TEntity : class
    {

    }

    /// <summary>
    /// Repository interface that will be used to query and manipulate
    /// persisted entities
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TId01">The entity id first type</typeparam>
    /// <typeparam name="TId02">The entity id second type</typeparam>
    public interface IRepository<TEntity, in TId01, in TId02> : IAsyncRepository<TEntity, TId01, TId02>, ISyncRepository<TEntity, TId01, TId02>
        where TEntity : class
    {

    }

    /// <summary>
    /// Repository interface that will be used to query and manipulate
    /// persisted entities
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TId01">The entity id first type</typeparam>
    /// <typeparam name="TId02">The entity id second type</typeparam>
    /// <typeparam name="TId03">The entity id third type</typeparam>
    public interface IRepository<TEntity, in TId01, in TId02, in TId03> : IAsyncRepository<TEntity, TId01, TId02, TId03>, ISyncRepository<TEntity, TId01, TId02, TId03>
        where TEntity : class
    {

    }

    /// <summary>
    /// Repository interface that will be used to query and manipulate
    /// persisted entities
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TId01">The entity id first type</typeparam>
    /// <typeparam name="TId02">The entity id second type</typeparam>
    /// <typeparam name="TId03">The entity id third type</typeparam>
    /// <typeparam name="TId04">The entity id fourth type</typeparam>
    public interface IRepository<TEntity, in TId01, in TId02, in TId03, in TId04> : IAsyncRepository<TEntity, TId01, TId02, TId03, TId04>, ISyncRepository<TEntity, TId01, TId02, TId03, TId04>
        where TEntity : class
    {

    }

    /// <summary>
    /// Repository interface that will be used to query and manipulate
    /// persisted entities
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface IRepository<TEntity> : IAsyncRepository<TEntity>, ISyncRepository<TEntity>
        where TEntity : class
    {

    }
}
