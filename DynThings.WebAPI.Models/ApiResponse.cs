﻿/////////////////////////////////////////////////////////////////
// Created by : Arshad Ashraf                                   //
// TimeStamp  : 03-02-2016                                      //
// Content    : Handle Api Responses                            //
// Notes      :                                                 //
/////////////////////////////////////////////////////////////////
using DynThings.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;

namespace DynThings.WebAPI.Models
{
    #region Enums : Result Type
    public enum ResultType
    {
        Ok = 0,
        Failed = 1
    }
    #endregion

    #region APIResponse
    public class ApiResponse
    {
        #region :: Public Properites ::
        public long resultID { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public long Reference { get; set; }

        #endregion

        #region :: Constructor ::
        public ApiResponse()
        {
            this.resultID = 0;
            this.Status = "";
            this.Message = "";
            this.Reference = 0;
        }
        #endregion

    }
    #endregion


    //public partial class TypesMapper
    //{
    //    public class ApiResponseAdapter
    //    {

    //        public ApiResponse fromResult(ResultInfo.Result sourceResult)
    //        {
    //            ApiResponse result = new ApiResponse();
    //            result.resultID = sourceResult.ResultID;
    //            result.Message = sourceResult.Message;
    //            result.Reference = sourceResult.Reference;

    //            if (sourceResult.ResultType.GetHashCode().ToString() == "0")
    //            {
    //                result.Status = "OK";
    //            }
    //            else
    //            {
    //                result.Status = "Error";
    //            }
    //            return result;
    //        }
    //    }

    //}
}