FILE = URI_1044

all : $(FILE)

$(FILE): compile
	mono $@.exe

compile: $(FILE).cs
	mcs $< -out:$(FILE).exe

hadouken: $(FILE).exe
	mono $(FILE).exe

clean:
	del /f $(FILE).exe
