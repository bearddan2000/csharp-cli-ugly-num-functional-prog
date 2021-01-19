FROM mono:latest

ARG IN_FILE="Main.cs"
ARG OUT_FILE="Main.exe"

COPY src/ .

RUN chmod +x ${IN_FILE} \
    && mcs -o:${OUT_FILE} ${IN_FILE} \
    && chmod +x ${OUT_FILE}

CMD ["mono", "Main.exe"]
