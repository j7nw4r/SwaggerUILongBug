# SwaggerUILongBug

This repo is used to showcase a bug in Swagger/Swashbuckler UI. When returning longs, it seems that the least significant 8 bits are modified. This seems to happen only when using Swagger UI. Cannot replicate using other tools (Postman).
