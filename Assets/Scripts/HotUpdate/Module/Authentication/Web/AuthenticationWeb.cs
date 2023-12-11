using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using EZ;
using UnityEngine;

namespace Game.HotUpdate.Web {
    public class AuthenticationWeb {
        public static async UniTask<LoginWebData.TestData> GetTestData() {
            RestApi.QueryParameter queryParameter = new RestApi.QueryParameter();
            queryParameter.name = "id";
            queryParameter.value = "2";
            var text = await GFX.Web.GetText("", queryParameter);
            if (text != null) {
                return JsonUtility.FromJson<LoginWebData.TestData>(text);
            } else {
                return null;
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="request">登入返回</param>
        /// <returns></returns>
        public static async UniTask<LoginWebData.LoginResponse> Login(LoginWebData.LoginRequest request) {
            RestApi.QueryParameter queryParameter = new RestApi.QueryParameter();
            queryParameter.name = "id";
            queryParameter.value = "2";
            var text = await GFX.Web.GetText("", queryParameter);
            if (text != null) {
                return JsonUtility.FromJson<LoginWebData.LoginResponse>(text);
            } else {
                return null;
            }
        }

        /// <summary>
        /// 绑定账号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static async UniTask<LoginWebData.BingAccountResponse> BingAccount(
            LoginWebData.BingAccountRequest request) {
            RestApi.QueryParameter queryParameter = new RestApi.QueryParameter();
            queryParameter.name = "id";
            queryParameter.value = "2";
            var text = await GFX.Web.GetText("", queryParameter);
            if (text != null) {
                return JsonUtility.FromJson<LoginWebData.BingAccountResponse>(text);
            } else {
                return null;
            }
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public static async UniTask<LoginWebData.LoginResponse> Logout() {
            RestApi.QueryParameter queryParameter = new RestApi.QueryParameter();
            queryParameter.name = "id";
            queryParameter.value = "2";
            var text = await GFX.Web.GetText("", queryParameter);
            if (text != null) {
                return JsonUtility.FromJson<LoginWebData.LoginResponse>(text);
            } else {
                return null;
            }
        }
    }
}