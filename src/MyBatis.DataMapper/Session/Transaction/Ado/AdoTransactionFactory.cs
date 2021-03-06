
#region Apache Notice
/*****************************************************************************
 * $Header: $
 * $Revision: 513043 $
 * $Date: 2008-06-28 09:26:16 -0600 (Sat, 28 Jun 2008) $
 * 
 * iBATIS.NET Data Mapper
 * Copyright (C) 2008/2005 - The Apache Software Foundation
 *  
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 ********************************************************************************/
#endregion

using System.Data;

namespace MyBatis.DataMapper.Session.Transaction.Ado
{
    /// <summary>
    /// Create <see cref="ITransaction" /> instance that will use ADO.NET <see cref="IDbTransaction"/>
    /// </summary>
    public class AdoTransactionFactory : ITransactionFactory
    {
        #region ITransactionFactory Members

        /// <summary>
        /// Creates a new <see cref="ITransaction"/> instance.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public ITransaction Create(ISession session)
        {
            ITransaction transaction = new AdoTransaction(session);
            return transaction;
        }

        #endregion
    }
}
