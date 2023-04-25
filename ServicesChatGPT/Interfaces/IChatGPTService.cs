﻿using Domain.ValueObjects;
using ServicesChatGPT.Models.Completion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesChatGPT.Interfaces
{
    public interface IChatGPTService
    {
        Task<BusinessResult<ChatCompletionResponse>> CompletionsAsync(ChatCompletionRequest request);
    }
}
