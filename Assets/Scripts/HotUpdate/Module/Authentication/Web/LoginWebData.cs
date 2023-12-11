using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.HotUpdate.Web {
    public class LoginWebData {
        public class TestData {
            public int code;
            public string msg;
            public string data;
        }

        /// <summary>
        /// 登录请求
        /// </summary>
        public class LoginRequest {
            /// <summary>
            /// 登入类型 1游客 2facebook 3google 4apple
            /// </summary>
            public int loginType;

            /// <summary>
            /// 登入类型为游客时，为空
            /// 登入类型为facebook时，传入facebookId
            /// </summary>
            public string openId;
        }

        /// <summary>
        /// 登陆返回
        /// </summary>
        public class LoginResponse {
            /// <summary>
            ///  权限token
            /// </summary>
            public string token;
        }

        /// <summary>
        /// 绑定账号请求
        /// </summary>
        public class BingAccountRequest {
            /// <summary>
            /// 登入类型 1游客 2facebook 3google 4apple
            /// </summary>
            public int loginType;

            /// <summary>
            /// 登入类型为游客时，为空
            /// 登入类型为facebook时，传入facebookId
            /// </summary>
            public string openId;
        }

        /// <summary>
        /// 绑定账号返回
        /// </summary>
        public class BingAccountResponse {
        }

        /// <summary>
        /// 登出请求
        /// </summary>
        public class LogoutRequest {
        }

        /// <summary>
        /// 登出返回
        /// </summary>
        public class LogoutResponse {
        }
    }
}