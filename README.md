# SwaggerUILongBug

This repo is used to showcase a bug in Swagger/Swashbuckler UI. When returning longs, it seems that the least significant 8 bits are modified. This seems to happen only when using Swagger UI. Cannot replicate using other tools (Postman).


Steps to replicate:

Build and run the project. Go to the swagger UI page and hit the test endpoint. If you compare the returned long with the long output to console, you'll see that they're not the same. However the output binary are the same. If the same experiment is tried with Postman, both the longs and the binary is correct.