/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DevicesBindInfoL7Listener : AbstractModel
    {
        
        /// <summary>
        /// 七层监听器实例ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 七层监听器协议类型，可选值：http,https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 七层监听器的监听端口。
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public long? LoadBalancerPort{ get; set; }

        /// <summary>
        /// 返回的转发规则列表。
        /// </summary>
        [JsonProperty("RuleSet")]
        public DevicesBindInfoRule[] RuleSet{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "LoadBalancerPort", this.LoadBalancerPort);
            this.SetParamArrayObj(map, prefix + "RuleSet.", this.RuleSet);
        }
    }
}

