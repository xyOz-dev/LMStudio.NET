
  <a href="Ω"><img src="http://readme-typing-svg.herokuapp.com?font=VT323&size=90&duration=1300&pause=0700&color=39008a&center=true&random=false&width=1100&height=140&lines=%E2%98%A6++LMStudio.NET++%E2%98%A6;Enjoy" alt="Ω" /></a>

LMStudio.NET is a .NET client library for interacting with the LM Studio server API. It provides an easy-to-use interface for working with chat completions, model listings, structured JSON responses, and tool integrations—similar to the OpenAI Chat Completions API.

> **Note:** LMStudioNET is designed to work with an LM Studio server (default endpoint: `http://127.0.0.1:1234`). Ensure your server is running and the desired model is downloaded and loaded before using the client.

---

## Features

- **Chat Completions:**  
  Create chat completions with support for both standard (accumulated) responses and streaming tokens.

- **Structured Output:**  
  Request structured JSON responses by supplying a JSON schema. This allows your model to output valid JSON conforming to your defined schema.

- **Tool Use Integration:**  
  Enable tool calls where the model can suggest function executions. Your code can then interpret these tool calls, execute the corresponding functions, and feed the results back into the conversation.

- **Model Management:**  
  Retrieve the list of available models and fetch details for individual models.

---
