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

namespace TencentCloud.As.V20180419
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.As.V20180419.Models;

   public class AsClient : AbstractClient{

       private const string endpoint = "as.tencentcloudapi.com";
       private const string version = "2018-04-19";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public AsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public AsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AttachInstances）用于将 CVM 实例添加到伸缩组。
        /// </summary>
        /// <param name="req">参考<see cref="AttachInstancesRequest"/></param>
        /// <returns>参考<see cref="AttachInstancesResponse"/>实例</returns>
        public async Task<AttachInstancesResponse> AttachInstances(AttachInstancesRequest req)
        {
             JsonResponseModel<AttachInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CompleteLifecycleAction）用于完成生命周期动作。
        /// 
        /// * 用户通过调用本接口，指定一个具体的生命周期挂钩的结果（“CONITNUE”或者“ABANDON”）。如果一直不调用本接口，则生命周期挂钩会在超时后按照“DefaultResult”进行处理。
        /// </summary>
        /// <param name="req">参考<see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns>参考<see cref="CompleteLifecycleActionResponse"/>实例</returns>
        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleAction(CompleteLifecycleActionRequest req)
        {
             JsonResponseModel<CompleteLifecycleActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompleteLifecycleAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteLifecycleActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAutoScalingGroup）用于创建伸缩组
        /// </summary>
        /// <param name="req">参考<see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns>参考<see cref="CreateAutoScalingGroupResponse"/>实例</returns>
        public async Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroup(CreateAutoScalingGroupRequest req)
        {
             JsonResponseModel<CreateAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateLaunchConfiguration）用于创建新的启动配置。
        /// 
        /// * 启动配置，可以通过 `ModifyLaunchConfigurationAttributes` 修改少量字段。如需使用新的启动配置，建议重新创建启动配置。
        /// 
        /// * 每个项目最多只能创建20个启动配置，详见[使用限制](https://cloud.tencent.com/document/product/377/3120)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns>参考<see cref="CreateLaunchConfigurationResponse"/>实例</returns>
        public async Task<CreateLaunchConfigurationResponse> CreateLaunchConfiguration(CreateLaunchConfigurationRequest req)
        {
             JsonResponseModel<CreateLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateLifecycleHook）用于创建生命周期挂钩。
        /// 
        /// * 您可以为生命周期挂钩配置消息通知，弹性伸缩会通知您的CMQ消息队列，通知内容形如：
        /// 
        /// ```
        /// {
        /// 	"Service": "Tencent Cloud Auto Scaling",
        /// 	"Time": "2019-03-14T10:15:11Z",
        /// 	"AppId": "1251783334",
        /// 	"ActivityId": "asa-fznnvrja",
        /// 	"AutoScalingGroupId": "asg-rrrrtttt",
        /// 	"LifecycleHookId": "ash-xxxxyyyy",
        /// 	"LifecycleHookName": "my-hook",
        /// 	"LifecycleActionToken": "3080e1c9-0efe-4dd7-ad3b-90cd6618298f",
        /// 	"InstanceId": "ins-aaaabbbb",
        /// 	"LifecycleTransition": "INSTANCE_LAUNCHING",
        /// 	"NotificationMetadata": ""
        /// }
        /// ```
        /// </summary>
        /// <param name="req">参考<see cref="CreateLifecycleHookRequest"/></param>
        /// <returns>参考<see cref="CreateLifecycleHookResponse"/>实例</returns>
        public async Task<CreateLifecycleHookResponse> CreateLifecycleHook(CreateLifecycleHookRequest req)
        {
             JsonResponseModel<CreateLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotificationConfiguration）用于创建通知。
        /// </summary>
        /// <param name="req">参考<see cref="CreateNotificationConfigurationRequest"/></param>
        /// <returns>参考<see cref="CreateNotificationConfigurationResponse"/>实例</returns>
        public async Task<CreateNotificationConfigurationResponse> CreateNotificationConfiguration(CreateNotificationConfigurationRequest req)
        {
             JsonResponseModel<CreateNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreatePaiInstance) 用于创建一个指定配置的PAI实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePaiInstanceRequest"/></param>
        /// <returns>参考<see cref="CreatePaiInstanceResponse"/>实例</returns>
        public async Task<CreatePaiInstanceResponse> CreatePaiInstance(CreatePaiInstanceRequest req)
        {
             JsonResponseModel<CreatePaiInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePaiInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePaiInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateScalingPolicy）用于创建告警触发策略。
        /// </summary>
        /// <param name="req">参考<see cref="CreateScalingPolicyRequest"/></param>
        /// <returns>参考<see cref="CreateScalingPolicyResponse"/>实例</returns>
        public async Task<CreateScalingPolicyResponse> CreateScalingPolicy(CreateScalingPolicyRequest req)
        {
             JsonResponseModel<CreateScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateScheduledAction）用于创建定时任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateScheduledActionRequest"/></param>
        /// <returns>参考<see cref="CreateScheduledActionResponse"/>实例</returns>
        public async Task<CreateScheduledActionResponse> CreateScheduledAction(CreateScheduledActionRequest req)
        {
             JsonResponseModel<CreateScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAutoScalingGroup）用于删除指定伸缩组，删除前提是伸缩组内无实例且当前未在执行伸缩活动。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteAutoScalingGroupResponse"/>实例</returns>
        public async Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest req)
        {
             JsonResponseModel<DeleteAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteLaunchConfiguration）用于删除启动配置。
        /// 
        /// * 若启动配置在伸缩组中属于生效状态，则该启动配置不允许删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLaunchConfigurationRequest"/></param>
        /// <returns>参考<see cref="DeleteLaunchConfigurationResponse"/>实例</returns>
        public async Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest req)
        {
             JsonResponseModel<DeleteLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteLifecycleHook）用于删除生命周期挂钩。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns>参考<see cref="DeleteLifecycleHookResponse"/>实例</returns>
        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHook(DeleteLifecycleHookRequest req)
        {
             JsonResponseModel<DeleteLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNotificationConfiguration）用于删除特定的通知。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns>参考<see cref="DeleteNotificationConfigurationResponse"/>实例</returns>
        public async Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest req)
        {
             JsonResponseModel<DeleteNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteScalingPolicy）用于删除告警触发策略。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns>参考<see cref="DeleteScalingPolicyResponse"/>实例</returns>
        public async Task<DeleteScalingPolicyResponse> DeleteScalingPolicy(DeleteScalingPolicyRequest req)
        {
             JsonResponseModel<DeleteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteScheduledAction）用于删除特定的定时任务。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteScheduledActionRequest"/></param>
        /// <returns>参考<see cref="DeleteScheduledActionResponse"/>实例</returns>
        public async Task<DeleteScheduledActionResponse> DeleteScheduledAction(DeleteScheduledActionRequest req)
        {
             JsonResponseModel<DeleteScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccountLimits）用于查询用户账户在弹性伸缩中的资源限制。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountLimitsResponse"/>实例</returns>
        public async Task<DescribeAccountLimitsResponse> DescribeAccountLimits(DescribeAccountLimitsRequest req)
        {
             JsonResponseModel<DescribeAccountLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingActivities）用于查询伸缩组的伸缩活动记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns>参考<see cref="DescribeAutoScalingActivitiesResponse"/>实例</returns>
        public async Task<DescribeAutoScalingActivitiesResponse> DescribeAutoScalingActivities(DescribeAutoScalingActivitiesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingGroups）用于查询伸缩组信息。
        /// 
        /// * 可以根据伸缩组ID、伸缩组名称或者启动配置ID等信息来查询伸缩组的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的伸缩组。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAutoScalingGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeAutoScalingGroupsResponse"/>实例</returns>
        public async Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest req)
        {
             JsonResponseModel<DescribeAutoScalingGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAutoScalingInstances）用于查询弹性伸缩关联实例的信息。
        /// 
        /// * 可以根据实例ID、伸缩组ID等信息来查询实例的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的实例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAutoScalingInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeAutoScalingInstancesResponse"/>实例</returns>
        public async Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLaunchConfigurations）用于查询启动配置的信息。
        /// 
        /// * 可以根据启动配置ID、启动配置名称等信息来查询启动配置的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的启动配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLaunchConfigurationsRequest"/></param>
        /// <returns>参考<see cref="DescribeLaunchConfigurationsResponse"/>实例</returns>
        public async Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest req)
        {
             JsonResponseModel<DescribeLaunchConfigurationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLaunchConfigurations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLaunchConfigurationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLifecycleHooks）用于查询生命周期挂钩信息。
        /// 
        /// * 可以根据伸缩组ID、生命周期挂钩ID或者生命周期挂钩名称等信息来查询生命周期挂钩的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的生命周期挂钩。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLifecycleHooksRequest"/></param>
        /// <returns>参考<see cref="DescribeLifecycleHooksResponse"/>实例</returns>
        public async Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooks(DescribeLifecycleHooksRequest req)
        {
             JsonResponseModel<DescribeLifecycleHooksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLifecycleHooks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLifecycleHooksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeNotificationConfigurations) 用于查询一个或多个通知的详细信息。
        /// 
        /// 可以根据通知ID、伸缩组ID等信息来查询通知的详细信息。过滤信息详细请见过滤器`Filter`。
        /// 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的通知。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNotificationConfigurationsRequest"/></param>
        /// <returns>参考<see cref="DescribeNotificationConfigurationsResponse"/>实例</returns>
        public async Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest req)
        {
             JsonResponseModel<DescribeNotificationConfigurationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotificationConfigurations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotificationConfigurationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePaiInstances）用于查询PAI实例信息。
        /// 
        /// * 可以根据实例ID、实例域名等信息来查询PAI实例的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的PAI实例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePaiInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribePaiInstancesResponse"/>实例</returns>
        public async Task<DescribePaiInstancesResponse> DescribePaiInstances(DescribePaiInstancesRequest req)
        {
             JsonResponseModel<DescribePaiInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePaiInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePaiInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeScalingPolicies）用于查询告警触发策略。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns>参考<see cref="DescribeScalingPoliciesResponse"/>实例</returns>
        public async Task<DescribeScalingPoliciesResponse> DescribeScalingPolicies(DescribeScalingPoliciesRequest req)
        {
             JsonResponseModel<DescribeScalingPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScalingPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScalingPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeScheduledActions) 用于查询一个或多个定时任务的详细信息。
        /// 
        /// * 可以根据定时任务ID、定时任务名称或者伸缩组ID等信息来查询定时任务的详细信息。过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的定时任务。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns>参考<see cref="DescribeScheduledActionsResponse"/>实例</returns>
        public async Task<DescribeScheduledActionsResponse> DescribeScheduledActions(DescribeScheduledActionsRequest req)
        {
             JsonResponseModel<DescribeScheduledActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScheduledActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScheduledActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachInstances）用于从伸缩组移出 CVM 实例，本接口不会销毁实例。
        /// </summary>
        /// <param name="req">参考<see cref="DetachInstancesRequest"/></param>
        /// <returns>参考<see cref="DetachInstancesResponse"/>实例</returns>
        public async Task<DetachInstancesResponse> DetachInstances(DetachInstancesRequest req)
        {
             JsonResponseModel<DetachInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableAutoScalingGroup）用于停用指定伸缩组。
        /// </summary>
        /// <param name="req">参考<see cref="DisableAutoScalingGroupRequest"/></param>
        /// <returns>参考<see cref="DisableAutoScalingGroupResponse"/>实例</returns>
        public async Task<DisableAutoScalingGroupResponse> DisableAutoScalingGroup(DisableAutoScalingGroupRequest req)
        {
             JsonResponseModel<DisableAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableAutoScalingGroup）用于启用指定伸缩组。
        /// </summary>
        /// <param name="req">参考<see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns>参考<see cref="EnableAutoScalingGroupResponse"/>实例</returns>
        public async Task<EnableAutoScalingGroupResponse> EnableAutoScalingGroup(EnableAutoScalingGroupRequest req)
        {
             JsonResponseModel<EnableAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAutoScalingGroup）用于修改伸缩组。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns>参考<see cref="ModifyAutoScalingGroupResponse"/>实例</returns>
        public async Task<ModifyAutoScalingGroupResponse> ModifyAutoScalingGroup(ModifyAutoScalingGroupRequest req)
        {
             JsonResponseModel<ModifyAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDesiredCapacity）用于修改指定伸缩组的期望实例数
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns>参考<see cref="ModifyDesiredCapacityResponse"/>实例</returns>
        public async Task<ModifyDesiredCapacityResponse> ModifyDesiredCapacity(ModifyDesiredCapacityRequest req)
        {
             JsonResponseModel<ModifyDesiredCapacityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDesiredCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDesiredCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyLaunchConfigurationAttributes）用于修改启动配置部分属性。
        /// 
        /// * 修改启动配置后，已经使用该启动配置扩容的存量实例不会发生变更，此后使用该启动配置的新增实例会按照新的配置进行扩容。
        /// * 本接口支持修改部分简单类型。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLaunchConfigurationAttributesRequest"/></param>
        /// <returns>参考<see cref="ModifyLaunchConfigurationAttributesResponse"/>实例</returns>
        public async Task<ModifyLaunchConfigurationAttributesResponse> ModifyLaunchConfigurationAttributes(ModifyLaunchConfigurationAttributesRequest req)
        {
             JsonResponseModel<ModifyLaunchConfigurationAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLaunchConfigurationAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaunchConfigurationAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancers）用于修改伸缩组的负载均衡器。
        /// 
        /// * 本接口用于为伸缩组指定新的负载均衡器配置，采用“完全覆盖”风格，无论之前配置如何，统一按照接口参数配置为新的负载均衡器。
        /// * 如果要为伸缩组清空负载均衡器，则在调用本接口时仅指定伸缩组ID，不指定具体负载均衡器。
        /// * 本接口会立即修改伸缩组的负载均衡器，并生成一个伸缩活动，异步修改存量实例的负载均衡器。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLoadBalancersRequest"/></param>
        /// <returns>参考<see cref="ModifyLoadBalancersResponse"/>实例</returns>
        public async Task<ModifyLoadBalancersResponse> ModifyLoadBalancers(ModifyLoadBalancersRequest req)
        {
             JsonResponseModel<ModifyLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNotificationConfiguration）用于修改通知。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns>参考<see cref="ModifyNotificationConfigurationResponse"/>实例</returns>
        public async Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfiguration(ModifyNotificationConfigurationRequest req)
        {
             JsonResponseModel<ModifyNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyScalingPolicy）用于修改告警触发策略。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns>参考<see cref="ModifyScalingPolicyResponse"/>实例</returns>
        public async Task<ModifyScalingPolicyResponse> ModifyScalingPolicy(ModifyScalingPolicyRequest req)
        {
             JsonResponseModel<ModifyScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyScheduledAction）用于修改定时任务。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyScheduledActionRequest"/></param>
        /// <returns>参考<see cref="ModifyScheduledActionResponse"/>实例</returns>
        public async Task<ModifyScheduledActionResponse> ModifyScheduledAction(ModifyScheduledActionRequest req)
        {
             JsonResponseModel<ModifyScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（PreviewPaiDomainName）用于预览PAI实例域名。
        /// </summary>
        /// <param name="req">参考<see cref="PreviewPaiDomainNameRequest"/></param>
        /// <returns>参考<see cref="PreviewPaiDomainNameResponse"/>实例</returns>
        public async Task<PreviewPaiDomainNameResponse> PreviewPaiDomainName(PreviewPaiDomainNameRequest req)
        {
             JsonResponseModel<PreviewPaiDomainNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PreviewPaiDomainName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewPaiDomainNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RemoveInstances）用于从伸缩组删除 CVM 实例。根据当前的产品逻辑，如果实例由弹性伸缩自动创建，则实例会被销毁；如果实例系创建后加入伸缩组的，则会从伸缩组中移除，保留实例。
        /// </summary>
        /// <param name="req">参考<see cref="RemoveInstancesRequest"/></param>
        /// <returns>参考<see cref="RemoveInstancesResponse"/>实例</returns>
        public async Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
             JsonResponseModel<RemoveInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetInstancesProtection）用于设置实例移除保护。
        /// 子机设置为移除保护之后，当发生不健康替换、报警策略、期望值变更等触发缩容时，将不对此子机缩容操作。
        /// </summary>
        /// <param name="req">参考<see cref="SetInstancesProtectionRequest"/></param>
        /// <returns>参考<see cref="SetInstancesProtectionResponse"/>实例</returns>
        public async Task<SetInstancesProtectionResponse> SetInstancesProtection(SetInstancesProtectionRequest req)
        {
             JsonResponseModel<SetInstancesProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetInstancesProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetInstancesProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeLaunchConfiguration）用于升级启动配置。
        /// 
        /// * 本接口用于升级启动配置，采用“完全覆盖”风格，无论之前参数如何，统一按照接口参数设置为新的配置。对于非必填字段，不填写则按照默认值赋值。
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns>参考<see cref="UpgradeLaunchConfigurationResponse"/>实例</returns>
        public async Task<UpgradeLaunchConfigurationResponse> UpgradeLaunchConfiguration(UpgradeLaunchConfigurationRequest req)
        {
             JsonResponseModel<UpgradeLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeLifecycleHook）用于升级生命周期挂钩。
        /// 
        /// * 本接口用于升级生命周期挂钩，采用“完全覆盖”风格，无论之前参数如何，统一按照接口参数设置为新的配置。对于非必填字段，不填写则按照默认值赋值。
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns>参考<see cref="UpgradeLifecycleHookResponse"/>实例</returns>
        public async Task<UpgradeLifecycleHookResponse> UpgradeLifecycleHook(UpgradeLifecycleHookRequest req)
        {
             JsonResponseModel<UpgradeLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
