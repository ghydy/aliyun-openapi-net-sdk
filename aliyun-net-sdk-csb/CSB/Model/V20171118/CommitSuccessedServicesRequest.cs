/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CSB.Transform;
using Aliyun.Acs.CSB.Transform.V20171118;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Model.V20171118
{
    public class CommitSuccessedServicesRequest : RpcAcsRequest<CommitSuccessedServicesResponse>
    {
        public CommitSuccessedServicesRequest()
            : base("CSB", "2017-11-18", "CommitSuccessedServices")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string csbName;

		private string services;

		public string CsbName
		{
			get
			{
				return csbName;
			}
			set	
			{
				csbName = value;
				DictionaryUtil.Add(QueryParameters, "CsbName", value);
			}
		}

		public string Services
		{
			get
			{
				return services;
			}
			set	
			{
				services = value;
				DictionaryUtil.Add(BodyParameters, "Services", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CommitSuccessedServicesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CommitSuccessedServicesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}