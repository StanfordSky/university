@echo off
set a=%1
if defined %a% (set %a%) else (echo Variable "%a%" not defined)
