﻿// Project site: https://github.com/iluvadev/PocketBaseClient-csharp
//
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// Copyright (c) 2022, iluvadev, and released under MIT License.
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

namespace PocketBaseClient.Services
{

    /// <summary>
    /// Authentication Operation types
    /// </summary>
    public class AuthService: ServiceBase
    {
        private AuthAdminService? _Admin = null;
        /// <summary>
        /// Authenticate as Admin actions
        /// </summary>
        public AuthAdminService Admin => _Admin ??= new AuthAdminService(App);

        private AuthUserService? _User = null;
        /// <summary>
        /// Authenticate as User actions
        /// </summary>
        public AuthUserService User => _User ??= new AuthUserService(App);

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="app"></param>
        public AuthService(PocketBaseClientApplication app) : base(app) { }
    }
}
